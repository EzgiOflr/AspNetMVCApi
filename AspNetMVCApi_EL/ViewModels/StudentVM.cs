using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMVCApi_EL.ViewModels
{
    public class StudentVM //Student view model
    {

        public int Id { get; set; }
       
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Adınız en az 2 en çok 50 karakter olmalıdır!")]
        public string Name { get; set; }
       
        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Soyadınız en az 2 en çok 50 karakter olmalıdır!")]
        public string Surname { get; set; }

        public DateTime RegisterDate { get; set; }
    }
}
