using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebProyect.Models
{
    public class Stock
    {
        public int IDproduct { get; set; }
    
        public string ProductName { get; set; } = string.Empty;

        public string ProductDescription { get; set; } = string.Empty;

        public decimal Price { get; set; } = 0;

        public string ImageProductUrl { get; set; }  = string.Empty;

    }
}
