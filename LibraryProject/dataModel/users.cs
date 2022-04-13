using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.dataModel
{
    class users
    {
        [Key]
        public int UserId { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public int phoneNumber { get; set; }
        public int PESEL { get; set; }
    }
}
