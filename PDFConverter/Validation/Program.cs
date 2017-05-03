using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            bankcardsValidation v = new bankcardsValidation();
            v.MatchCard("36123456780009");
        }
    }
}
