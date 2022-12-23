using WebProje.Data.Base;
using WebProje.Models;



namespace WebProje.Data.Services
{
    public interface ICinemasService
    {
        public interface ICinemasService : IEntityBaseRepository<Cinema>
        {
        }
    }
}
