using CA_OCP.Data;
using CA_OCP.Departments;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_OCP.Operation
{
    public class ChoosingCandidate : IChooseAC, IChooseHR, IChooseIT
    {


        public void ChooseAC(int x)
        {
            AC aC = new AC();

            Console.WriteLine("Rakam giriniz");
            int j = int.Parse(Console.ReadLine());

            foreach (AC person in ACCandidate.ACList)
            {
                if (person.ID == j)
                {
                    Console.WriteLine($"Seçilen Muhasebe Elemanı : {person.FirstName}  {person.LastName} mail: {person.FirstName.ToLower()}{person.LastName.ToLower()}@gmail.com");
                }
            }
        }

        public void ChooseHR(int x)
        {
            HR hR = new HR();


            for (int i = 0; i < 2; i++)
            {

                Console.WriteLine("Rakam giriniz");
                int j = int.Parse(Console.ReadLine());

                foreach (HR person in HRCandidate.HRList)
                {
                    if (person.ID == j)
                    {
                        Console.WriteLine($"Seçilen İnsan Kaynakları Elemanı: {person.FirstName}  {person.LastName} mail: {person.FirstName.ToLower()}{person.LastName.ToLower()}@gmail.com");
                    }

                }


            }


        }

        public void ChooseIT(int x)
        {
            IT iT = new IT();


            for (int i = 0; i < 2; i++)
            {

                Console.WriteLine("Rakam giriniz");
                int j = int.Parse(Console.ReadLine());

                foreach (IT person in ITCandidate.ITList)
                {
                    if (person.ID == j)
                    {
                        Console.WriteLine($"Seçilen IT Elemanı: {person.FirstName}  {person.LastName} mail: {person.FirstName.ToLower()}{person.LastName.ToLower()}@gmail.com");
                    }

                }


            }
        }
    }
}
    
