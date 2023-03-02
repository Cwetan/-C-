

using Project.DL.Inmemorydatabase;
using Project.DL.Interface;
using Project.Models.Data;

namespace Project.DL.Repositories
{
    public class AutorRepository : IAutoRepository
    {
        public void AddAutor(Autor autor)
        {
            Datastore.Autors.Add(autor);
        }

        public void DeleteAutor(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Autor> GetAll()
        {
            return Datastore.Autors;
        }

        public Autor GetById(int id)
        {
            return Datastore.Autors
                .FirstOrDefault(Autor => Autor.ID == id);

        }
    }
}

