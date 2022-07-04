using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ABP.GettingStarted.Products;
using ABP.GettingStarted.Products.Dtos;
using ABP.GettingStarted.Web.Pages.Products.Product.ViewModels;

namespace ABP.GettingStarted.Web.Pages.Products.Product
{
    public class EditModalModel : GettingStartedPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEditProductViewModel ViewModel { get; set; }

        private readonly IProductAppService _service;

        public EditModalModel(IProductAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<ProductDto, CreateEditProductViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditProductViewModel, CreateUpdateProductDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}