using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace _4101_BuiDucNhan.Models
{
    public class Product
    {
        [DisplayName("Mã sản phẩm")]
        public int Id { get; set; }

        [Required]
        [DisplayName("Tên sản phẩm")]
        [StringLength(100)]
        public string Name { get; set; }

        [DisplayName("Giá")]
        [Range(0.01, 10000.00)]
        public decimal Price { get; set; }

        [DisplayName("Mô tả")]
        public string Description { get; set; }

        [DisplayName("Mã loại")]
        public int CategoryId { get; set; }

        [Required]
        public string? ImageUrl { get; set; } // Đường dẫn đến hình ảnh đại diện

        [Required]
        public List<string>? ImageUrls { get; set; } // Danh sách các hình ảnh khác
    }
}
