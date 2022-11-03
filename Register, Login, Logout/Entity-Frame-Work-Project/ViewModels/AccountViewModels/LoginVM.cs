using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Frame_Work_Project.ViewModels.AccountViewModels
{
    public class LoginVM
    {
        [Required]
        public string UserNameOfEmail { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
