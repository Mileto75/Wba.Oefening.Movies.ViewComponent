using Microsoft.AspNetCore.Mvc;
using Wba.Oefening.Movies.Web.Models;
using Wba.Oefening.Movies.Web.Services;
using Wba.Oefening.Movies.Web.ViewModels;

namespace Wba.Oefening.Movies.Web.ViewComponents
{
    [ViewComponent(Name = "NavigationLinks")]
    public class NavigationLinksComponent : ViewComponent
    {
        private readonly LinkBuilderService _linkBuilderService;
        public NavigationLinksComponent()
        {
            _linkBuilderService = new LinkBuilderService();
        }

        public IViewComponentResult Invoke()
        {
            var actionLinksComponentViewModel
                = new NavigationLinksComponentViewModel
                {
                    ActionLinks = _linkBuilderService
                    .GetLinks()
                    .Select(l => new ActionLink 
                    {
                        Name = l.Name,
                        Controller = l.Controller,
                        Action = l.Action,
                    })
                };
            return View(actionLinksComponentViewModel);
        }
    }
}
