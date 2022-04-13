using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.dataModel
{
    class books
    {
        [Key]
        public int BookId { get; set; }
        public string genre { get; set; }
        public string name { get; set; }
        public string author { get; set; }
        public int stock { get; set; }
    }
}
