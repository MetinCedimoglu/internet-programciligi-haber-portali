namespace HaberPortalı.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsActive { get; set; }

        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        
        
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        
    }
}
