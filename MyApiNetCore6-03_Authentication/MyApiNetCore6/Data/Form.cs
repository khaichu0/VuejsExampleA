using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyApiNetCore6.Data
{
    [Table("Form")]
    public class Form
    {
        [Key]
        public Guid Id { get; set; }
        public Guid? UserId { get; set; }

        [MaxLength(100)]
        public string Title { get; set; }
        public string? Description { get; set; }

        
        public bool? RequireCaptcha { get; set; }
        public bool? RequireLogin { get; set; }
        public bool? IsPublished { get; set; }
        public bool? IsLimitToOne { get; set; }
        public int? MaxNumResponse { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

    }
}
