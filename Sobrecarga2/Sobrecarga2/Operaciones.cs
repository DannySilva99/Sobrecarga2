using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobrecarga2
{
    class Operaciones
    {
        Valores v = new Valores();
        Multiplicacion multiplicacion = new Multiplicacion();

        public void operaciones()
        {
            int Res1, Res2, Res3, Res4;
            Console.WriteLine("Ingrese un numero: ");
            v.Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro valor: ");
            v.Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro valor: ");
            v.Num3 = Convert.ToInt32(Console.ReadLine());

            Res1 = multiplicacion.Multiplicar(v.Num1, v.Num2, v.Num3);
            Res2 = multiplicacion.Multiplicar(v.Num1, v.Num2);
            Res3 = multiplicacion.Multiplicar(v.Num1);
            Res4 = multiplicacion.Multiplicar();

            Console.WriteLine("El resultado es: " + Res1);
            Console.WriteLine("El resultado es: " + Res2);
            Console.WriteLine("El resultado es: " + Res3);
            Console.WriteLine("El resultado es: " + Res4);

            Console.ReadKey();
        }
    }
}
