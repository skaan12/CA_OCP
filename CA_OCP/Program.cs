using CA_OCP.Operation;

namespace CA_OCP
{
    class Program
    {

        static void Main(string[] args)
        {
            int x = 0;
            ChoosingCandidate _choosingCandidate = new ChoosingCandidate();
            _choosingCandidate.ChooseAC(x);

            _choosingCandidate.ChooseHR(x);

            _choosingCandidate.ChooseIT(x);

        }
    }
}