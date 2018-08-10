using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodFinderDB
{
    class Brand
    {
        public int BrandID { get; set; }
        [Required(ErrorMessage = "Not Null")]

        public string BrandName { get; set; }
    }
}
