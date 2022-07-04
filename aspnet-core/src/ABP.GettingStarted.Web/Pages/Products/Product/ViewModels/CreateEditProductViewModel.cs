using System;

using System.ComponentModel.DataAnnotations;

namespace ABP.GettingStarted.Web.Pages.Products.Product.ViewModels
{
    public class CreateEditProductViewModel
    {
        [Display(Name = "ProductName")]
        public string Name { get; set; }

        [Display(Name = "ProductDescription")]
        public string Description { get; set; }

        [Display(Name = "ProductPrice")]
        public decimal Price { get; set; }
    }
}