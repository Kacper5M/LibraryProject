using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.dataModel
{
    class rentals
    {
        [Key]
        public int RentalId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
    }
}
