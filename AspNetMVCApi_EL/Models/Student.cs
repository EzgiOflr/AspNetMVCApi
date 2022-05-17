using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMVCApi_EL.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        [Column(Order =1)]
        public int Id { get; set; }
        [Column(Order = 3)]
        [Required]
        [StringLength(50,MinimumLength =2,ErrorMessage ="Adınız en az 2 en çok 50 karakter olmalıdır!")]
        public string Name { get; set; }
        [Column(Order = 4)]
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Soyadınız en az 2 en çok 50 karakter olmalıdır!")]
        public string Surname { get; set; }
        [Column(Order = 2 )]
        public DateTime RegisterDate { get; set; }
    }
}
