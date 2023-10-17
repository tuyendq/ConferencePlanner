
using System.ComponentModel.DataAnnotations;

namespace ConferencePlanner.GraphQL.Data
{
    public class Speaker
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public required string Name { get; set; }
        [StringLength(4000)]
        public String? Bio { get; set; }
        public virtual string? WebSite { get; set; }
    }
}