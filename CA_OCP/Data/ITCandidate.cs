using CA_OCP.Abstract;
using CA_OCP.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_OCP.Data
{
    public class ITCandidate
    {
        public static List<IT> ITList = new List<IT> 
        {
            new IT{ID = 1 , FirstName = "Ahmet" , LastName = "Uzun"},
            new IT{ID = 2 , FirstName = "Mehmet" , LastName = "Parmak"},
            new IT{ID = 3 , FirstName = "Kayhan" , LastName = "Ordu"},
            new IT{ID = 4 , FirstName = "Gokay" , LastName = "Lale"},
            new IT{ID = 5 , FirstName = "Kuzey" , LastName = "Ali"}
        };
    }
}
