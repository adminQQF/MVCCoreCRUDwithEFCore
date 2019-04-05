using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCoreCRUDwithEFCore.Models
{
    [Table("Loai")]
    public class Loai
    {
        [Key]
        [Display(Name ="Mã loại")]
        public int MaLoai { get; set; }

        [Display(Name = "Tên loại")]
        [Required(ErrorMessage ="*")]
        [MaxLength(50)]
        public string TenLoai { get; set; }

        [Display(Name = "Mô tả")]
        public string MoTa { get; set; }
    }
}
