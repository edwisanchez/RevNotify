using Fantasy.Frontend.Repositories;
using Microsoft.AspNetCore.Components;
using RevNotify.Shared.Entites;

namespace RevNotify.Frontend.Pages.Customers
{
    public partial class CustomersIndex
    {
        [Inject] private IRepository Repository { get; set; } = null!;
        private List<Customer>? Customers { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var responseHttp = await Repository.GetAsync<List<Customer>>("api/customers");
            Customers = responseHttp.Response;
        }
    }
}