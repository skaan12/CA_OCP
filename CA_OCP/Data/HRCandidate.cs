using CA_OCP.Abstract;
using CA_OCP.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_OCP.Data
{
    public class HRCandidate
    {
        public static List<HR> HRList = new List<HR> 
        {
            new HR{ID = 1 , FirstName = "Sena" , LastName = "Uyan"},
            new HR{ID = 2 , FirstName = "Fatma" , LastName = "Laci"},
            new HR{ID = 3 , FirstName = "Pelin" , LastName = "Taner"},
            new HR{ID = 4 , FirstName = "Tansu" , LastName = "Gezer"},
            new HR{ID = 5 , FirstName = "Merve" , LastName = "Kara"}
        };
        
    }
}
