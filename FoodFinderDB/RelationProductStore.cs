using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodFinderDB
{
    class RelationProductStore
    {
        public int StoreID { get; set; }
        //[ForeignKey("Supermarket")]
        public int SKU { get; set; }
        //[ForeignKey("Product")]
        public string ProductName { get; set; }
        //[ForeignKey("Product")]
    }
}



