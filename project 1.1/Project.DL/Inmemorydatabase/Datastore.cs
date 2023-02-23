using System.Xml.Linq;
using Project.Models.Data;

namespace Project.DL.Inmemorydatabase
{
    public class Datastore
    {
        public static List<Autor> Autors { get; set; }
        = new List<Autor>()
        {
            new Autor()
            {
                ID = 1,
                Name = "Gosho",
                BIO = "Gosho BIO"
            },
            new Autor()
             {
                ID = 1,
                Name = "Gosho",
                BIO = "Gosho BIO"
            }
        };
         
}
}