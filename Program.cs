using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba_moansoxd
{
    class Program
{
    static void Main(string[] args)
    {

            int n1, n2;
            Console.WriteLine("ingrese un numero: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro numero: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("la suma de los 2 numeros ingresado es: " + (n1 + n2));
        
            
            //modificado por miguel lorenzo torres
           Console.WriteLine("la resta de los 2 numeros ingresado es: " + (n2 - n1));
        
            //modificado por alan solorzano acosta
           Console.WriteLine("la multiplicacion de los 2 numeros ingresados es: " + (n1 * n2));
        }
}
}
