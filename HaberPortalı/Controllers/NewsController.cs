using AutoMapper;
using HaberPortalı.Dtos;
using HaberPortalı.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace HaberPortalı.Controllers
{
    [Route("api/News")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IMapper _mapper;
        ResultDto result = new ResultDto();
        public NewsController(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public List<NewsDto> GetList()
        {
            var newss = _context.Newss.ToList();
            var newssDtos = _mapper.Map<List<NewsDto>>(newss);
            return newssDtos;
        }

        [HttpGet]
        [Route("{id}")]
        public NewsDto Get(int id)
        {
            var news = _context.Newss.Where(s => s.Id == id).SingleOrDefault();
            var newsDto = _mapper.Map<NewsDto>(news);
            return newsDto;
        }

        [HttpGet]
        [Route("{id}/Authors")]
        public List<AuthorDto> GetAuthor(int id)
        {
            var authors = _context.Authors.Where(q => q.AuthorId == id).ToList();
            var authorDtos = _mapper.Map<List<AuthorDto>>(authors);
            return authorDtos;
        }

        [HttpPost]
        [Authorize]
        public ResultDto Post(NewsDto dto)
        {
            if (_context.Newss.Count(c => c.Title == dto.Title) > 0)
            {
                result.Status = false;
                result.Message = "Girilen Başlık Kayıtlıdır!";
                return result;
            }
            var news = _mapper.Map<News>(dto);
            news.Updated = DateTime.Now;
            news.Created = DateTime.Now;
            _context.Newss.Add(news);
            _context.SaveChanges();
            result.Status = true;
            result.Message = "Başlık Eklendi";
            return result;
        }


        [HttpPut]
        [Authorize(Roles = "Admin, Yazar")]
        public ResultDto Put(NewsDto dto)
        {
            var news = _context.Newss.Where(s => s.Id == dto.Id).SingleOrDefault();
            if (news == null)
            {
                result.Status = false;
                result.Message = "Haber Bulunamadı!";
                return result;
            }
            news.Title = dto.Title;
            news.IsActive = dto.IsActive;
            news.Content = dto.Content;
            news.Updated = DateTime.Now;
            news.CategoryId = dto.CategoryId;
            _context.Newss.Update(news);
            _context.SaveChanges();
            result.Status = true;
            result.Message = "Haber Düzenlendi";
            return result;
        }


        [HttpDelete]
        [Route("{id}")]
        [Authorize(Roles = "Admin, Yazar")]
        public ResultDto Delete(int id)
        {
            var news = _context.Newss.Where(s => s.Id == id).SingleOrDefault();
            if (news == null)
            {
                result.Status = false;
                result.Message = "Haber Bulunamadı!";
                return result;
            }
            _context.Newss.Remove(news);
            _context.SaveChanges();
            result.Status = true;
            result.Message = "Haber Silindi";
            return result;
        }


    }

}

