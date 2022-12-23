using WebProje.Models;

namespace WebProje.Data.ViewModels
{
    public class NewMovieDropdownsVM
    {
        public NewMovieDropdownsVM()
        {
            Cinemas = new List<Cinema>();
        }

        public List<Cinema> Cinemas { get; set; }
    }
}
