using System.ComponentModel.DataAnnotations;

namespace BlogApi.Domain.Entities
{
    public class Comment
    {
        public Guid Id { get; set; }

        [MaxLength(100)]
        [MinLength(3)]
        public string AuthorName { get; set; } = string.Empty;

        [MaxLength(100)]
        [MinLength(8)]
        public string Email { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public bool IsApproved { get; set; } = false;

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public Guid PostId { get; set; }

        public Post Post { get; set; } = null!;
    }
}
