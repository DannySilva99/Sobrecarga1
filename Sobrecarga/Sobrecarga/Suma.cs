using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga
{
    class Suma
    {
        public int Sumar(int Num1, int Num2, int Num3)
        {
            return Num1 + Num2 + Num3;
        }
        public int Sumar(int Num1, int Num2)
        {
            return Num1 + Num2;
        }
        public int Sumar(int Num1)
        {
            return Num1 + 5;
        }
        public int Sumar()
        {
            return 5 + 5;
        }
    }
}
