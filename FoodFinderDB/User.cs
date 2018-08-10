using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FoodFinderDB
{
    class User
    {          
        [Key]
        public int UserID { get; set; } // primary key
        [Required(ErrorMessage = "Not Null")]
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string Email { get; set; }// need to check if it is a string or varchar.
      
        public int Phone { get; set; }
      
    }
}

