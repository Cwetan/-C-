
using Project.Models.Data;

namespace Project.DL.Interface
{
    public interface IAutoRepository

    {
        IEnumerable<Autor> GetAll();

        Autor GetById(int id);

        void AddAutor(Autor autor);

        void DeleteAutor(int id);
    }
}
