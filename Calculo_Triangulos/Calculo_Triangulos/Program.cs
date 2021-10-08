using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculo_Triangulos
{
    class Program
    {
        static void Main()
        {
            /*Define os Triangulos*/
            Triangulos T1 = new Triangulos(4.6, 8.2);
            Triangulos T2 = new Triangulos(5, 6.5, 8.9);

            /*Chama função para calcular a area dos Triangulos*/
            T1.CalculaArea();
            T2.CalculaArea();

            /*Chama função para calcular a hipotenusa do Triangulos*/
            T1.CalculaHipotenusa();
            T2.CalculaHipotenusa();

            /*Chama função para calcular o perimetro do Triangulos*/
            T1.CalculaPerimetro();
            T2.CalculaPerimetro();

            /*Chama função estatica para comparar a area dos Triangulos e retorna a maior area*/
            Triangulos maiorTriangulo =  Triangulos.ComparaArea(T1, T2);



            Console.WriteLine("Base de T1: " + T1.GetBase());
            Console.WriteLine("Altura de T1: " + T1.GetAltura());
            Console.WriteLine("Hipotenusa de T1: " + T1.GetHipotenusa());
            Console.WriteLine("Perimetro de T1: " + T1.GetPerimetro());
            Console.WriteLine("Area de T1: " + T1.GetArea() + "\n");

            Console.WriteLine("Base de T2: " + T2.GetBase());
            Console.WriteLine("Altura de T2: " + T2.GetAltura());
            Console.WriteLine("Hipotenusa de T2: " + T2.GetHipotenusa());
            Console.WriteLine("Perimetro de T2: " + T2.GetPerimetro());
            Console.WriteLine("Area de T2: " + T2.GetArea() + "\n");

            Console.WriteLine("O maior triangulo eh: ");
            Console.WriteLine(maiorTriangulo.GetArea());

        }
    }
}
