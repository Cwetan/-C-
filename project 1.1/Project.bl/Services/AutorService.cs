using Project.bl.Interfaces;
using Project.DL.Repositories;
using Project.Models.Data;

namespace Project.bl.Services
{
    public class AutorService : IAutorServices
    {
       private readonly AutorRepository _autorRepository;

        public AutorService()
        {

        }
        public IEnumerable<Autor> GetAll()
        {
            return _autorRepository.GetAll();
        }

        public Autor GetById(int ID)
        {
            return _autorRepository.GetById(ID);
        }
    }
}
