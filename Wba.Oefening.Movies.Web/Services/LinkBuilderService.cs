using Wba.Oefening.Movies.Web.Models;

namespace Wba.Oefening.Movies.Web.Services
{
    public class LinkBuilderService
    {
        public IEnumerable<ActionLink> GetLinks()
        {
            return new ActionLink[]
            {
                new ActionLink{Controller = "Movies",Action="Index",Name="Movies" },
                new ActionLink{Controller = "People",Action="ShowActors",Name="Actors" },
                new ActionLink{Controller = "People",Action="ShowDirectors",Name="Directors" },
            };
        }
    }
}
