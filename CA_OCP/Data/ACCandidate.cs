using CA_OCP.Abstract;
using CA_OCP.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_OCP.Data
{
    public class ACCandidate
    {
        public static List<AC> ACList = new List<AC>
        {
            new AC {ID = 1 , FirstName = "Kaan", LastName = "Yilmaz"},
            new AC {ID = 2 , FirstName = "Burak ", LastName = "Kırmızı"},
            new AC {ID= 3 , FirstName = "Sercan" , LastName = "Balik"},
            new AC {ID= 4 , FirstName = "Muhammet" , LastName = "Yas"},
            new AC {ID= 5 , FirstName = "Haydar" , LastName = "Para"}
        };
    }
}
