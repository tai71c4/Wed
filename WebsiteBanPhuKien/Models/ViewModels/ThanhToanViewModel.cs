using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace WebsiteBanPhuKien.Models.ViewModels
{
    public class ThanhToanViewModel
    {
        public int MaDon { get; set; }
        
        [Required(ErrorMessage = "Vui lòng chọn phương thức thanh toán")]
        public string PhuongThucThanhToan { get; set; } = string.Empty;
        
        [Display(Name = "Ảnh xác nhận thanh toán")]
        public IFormFile? AnhThanhToan { get; set; }
        
        public string? GhiChu { get; set; }
        
        public decimal TongTien { get; set; }
        
        public string? TrangThai { get; set; }
    }
}