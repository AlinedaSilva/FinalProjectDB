using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FoodFinderDB
{
    class Supermarket
    {
        [Key]
        public int StoreID { get; set; }// primary key
        [Required(ErrorMessage = "Not Null")]

        public string StoreName { get; set; }
       
    }
}
