using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Wba.Oefening.Movies.Web.ViewModels;

namespace Wba.Oefening.Movies.Web.ViewComponents
{
    [ViewComponent(Name = "QuoteComponent")]
    public class QuoteViewComponent : ViewComponent
    {
        private const string _Url = "https://api.chucknorris.io/jokes/random";
        private readonly HttpClient _httpClient;

        public QuoteViewComponent()
        {
            _httpClient = new HttpClient();
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            //fetch the data from the api
            var result = await _httpClient.GetAsync(_Url);
            var content = await result.Content.ReadAsStringAsync();
            //put in viewmodel
            var quoteComponentViewModel =
                JsonSerializer.Deserialize<QuoteComponentViewModel>(content);
            //pass to view
            return View(quoteComponentViewModel);
        }
    }
}
