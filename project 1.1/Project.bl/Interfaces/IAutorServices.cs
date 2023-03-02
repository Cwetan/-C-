using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Models.Data;

namespace Project.bl.Interfaces
{
      public  interface IAutorServices
    {
        IEnumerable<Autor> GetAll();

        Autor GetById(int ID);
    }
}
