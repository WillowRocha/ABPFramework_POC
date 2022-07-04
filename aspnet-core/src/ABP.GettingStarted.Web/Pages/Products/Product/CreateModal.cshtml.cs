using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ABP.GettingStarted.Products;
using ABP.GettingStarted.Products.Dtos;
using ABP.GettingStarted.Web.Pages.Products.Product.ViewModels;

namespace ABP.GettingStarted.Web.Pages.Products.Product
{
    public class CreateModalModel : GettingStartedPageModel
    {
        [BindProperty]
        public CreateEditProductViewModel ViewModel { get; set; }

        private readonly IProductAppService _service;

        public CreateModalModel(IProductAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEditProductViewModel, CreateUpdateProductDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}