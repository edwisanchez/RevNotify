using Fantasy.Frontend.Repositories;
using Microsoft.AspNetCore.Components;
using RevNotify.Shared.Entites;

namespace RevNotify.Frontend.Pages.ProductCategories
{
    public partial class ProductCategoryIndex
    {
        [Inject] private IRepository Repository { get; set; } = null!;
        private List<ProductCategory>? ProductCategories { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var responseHttp = await Repository.GetAsync<List<ProductCategory>>("api/productCategory");
            ProductCategories = responseHttp.Response;
        }
    }
}