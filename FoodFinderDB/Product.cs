using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFinderDB
{
    class Product
    {
        [Key]
        public int SKU { get; set; }// primary key
        [Required(ErrorMessage = "Not Null")]

        public string ProductName { get; set; }        

        public int CategoryID { get; set; }
        //[ForeignKey("Category")]
    }
}

