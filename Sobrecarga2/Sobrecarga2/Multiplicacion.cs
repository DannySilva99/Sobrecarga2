using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga2
{
    class Multiplicacion
    {
        public int Multiplicar(int Num1, int Num2, int Num3)
        {
            return Num1 * Num2 * Num3;
        }
        public int Multiplicar(int Num1, int Num2)
        {
            return Num1 * Num2;
        }
        public int Multiplicar(int Num1)
        {
            return Num1 * 5;
        }
        public int Multiplicar()
        {
            return 5 * 5;
        }
    }
}
