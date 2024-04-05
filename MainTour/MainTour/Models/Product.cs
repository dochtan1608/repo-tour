using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MainTour.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        [StringLength(100)]
        public string? ProductName { get; set; }
        [StringLength(3000)]
        public string? ProductDescription { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        [Column(TypeName ="decimal(8,2)")]

        public decimal? ProductPridce { get; set; }
        [Column(TypeName = "decimal(2,2)")]
        public decimal PriceDiscount { get; set; }
        [StringLength(300)]
        public string? ProductPhoto { get; set; }
        public bool? IsTourAvailable { get; set; }
        public bool? IsTourHot { get; set; }

    }
}
