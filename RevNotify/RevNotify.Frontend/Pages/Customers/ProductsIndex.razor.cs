using Fantasy.Frontend.Repositories;
using Microsoft.AspNetCore.Components;
using RevNotify.Shared.Entites;

namespace RevNotify.Frontend.Pages.Customers
{
    public partial class ProductsIndex
    {
        [Inject] private IRepository Repository { get; set; } = null!;
        private List<Product>? Products { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var responseHttp = await Repository.GetAsync<List<Product>>("api/products");
            Products = responseHttp.Response;
        }
    }
}