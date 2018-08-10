using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodFinderDB
{
    class History
    {       
        [Key]
        public int OrderID { get; set; }
        [Required(ErrorMessage = "Not Null")]

        public int UserID { get; set; } // forneig key
        //[ForeignKey("User")]

        public int StoreID { get; set; }
        //[ForeignKey("Supermarket")]

        public int SKU { get; set; }
        //[ForeignKey("Product")]

        public string ProductName { get; set; }
        //[ForeignKey("Product")]

        public decimal Price { get; set; }
        //[ForeignKey("RelationProductStore")]

        public int Qty { get; set; }
       
        public DateTime Date { get; set; }
        //[ForeignKey("RelationProductStore")]        
    }
}
