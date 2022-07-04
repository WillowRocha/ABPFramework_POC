using System;
using System.ComponentModel;
namespace ABP.GettingStarted.Products.Dtos
{
    [Serializable]
    public class CreateUpdateProductDto
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }
    }
}