using System.Threading.Tasks;

namespace ABP.GettingStarted.Web.Pages.Products.Product
{
    public class IndexModel : GettingStartedPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
