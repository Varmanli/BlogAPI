using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;


namespace BlogApi.Domain.Entities
{
    public class Post
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; } = string.Empty;

        [MaxLength(500)]
        public string ShortDescription { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        [Required]
        public string Slug { get; set; } = string.Empty;

        [Url]
        public string? Thumbnail { get; set; }

        public int ViewCount { get; set; } = 0;

        public bool IsPublished { get; set; } = false;

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public Guid CategoryId { get; set; }

        public Category Category { get; set; } = null!;

        public ICollection<Tag> Tags { get; set; } = new List<Tag>();

        public ICollection<Comment> Comments { get; set; } = new List<Comment>();
    }
}
