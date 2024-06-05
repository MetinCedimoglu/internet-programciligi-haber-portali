namespace HaberPortalı.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public string UserId { get; set; }
        public AppUser AppUser { get; set; }

        public List<News> Newss { get; set; }
        public int AuthorId { get; internal set; }
    }
}
