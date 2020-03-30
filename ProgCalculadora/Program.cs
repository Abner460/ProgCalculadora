using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc1 = new Calculadora();

            calc1.addNumero(20.0);
            calc1.addNumero(15.0);
            System.Console.WriteLine(calc1.somar());

            Calculadora calc2 = new Calculadora();

            calc2.addNumero(20.0);
            calc2.addNumero(10.0);
            System.Console.WriteLine(calc2.subtrair());

            Calculadora calc3 = new Calculadora();

            calc3.addNumero(5.0);
            calc3.addNumero(3.0);
            System.Console.WriteLine(calc3.multiplicar());

            Calculadora calc4 = new Calculadora();

            calc4.addNumero(10);
            calc4.addNumero(5);
            System.Console.WriteLine(calc4.dividir());

            Calculadora calc5 = new Calculadora();

            calc5.addNumero(13);
            calc5.addNumero(3);
            calc5.addNumero(2);
            System.Console.WriteLine(calc5.media());

            System.Console.ReadKey();
        }
    }
}
