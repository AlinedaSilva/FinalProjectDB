using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodFinderDB
{
    class Category
    {
        public int CategoryID { get; set; }
        [Required(ErrorMessage = "Not Null")]

        public string CategoryName { get; set; }
        
    }
}
