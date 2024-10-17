namespace Wba.Oefening.Movies.Web.ViewModels
{
    public class MoviesShowMovieViewModel
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<BasePersonViewModel> Directors { get; set; }
        public IEnumerable<BasePersonViewModel> Actors { get; set; }
        public  string Genre{ get; set; }
        public string Image{ get; set; }
    }
}
