using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreCRUDwithEFCore.Models
{
    [Table("NhanVien")]
    public class NhanVien
    {
        [Display(Name ="Mã nhân viên")]
        public int NhanVienId { get; set; }
        [Display(Name ="Họ tên")]
        [Required(ErrorMessage ="*")]
        [MaxLength(50, ErrorMessage = "Tối đa 50 kí tự")]
        public string HoTen { get; set; }
        [Display(Name = "Vị trí")]
        [Required(ErrorMessage = "*")]
        [MaxLength(50, ErrorMessage = "Tối đa 20 kí tự")]
        public string ViTri { get; set; }
        [Display(Name = "Nơi làm việc")]
        [Required(ErrorMessage = "*")]
        [MaxLength(50, ErrorMessage = "Tối đa 150 kí tự")]
        public string NoiLamViec { get; set; }
        [Display(Name ="Mức lương")]        
        public double MucLuong { get; set; }
    }
}
