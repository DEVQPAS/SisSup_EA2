using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_Triangulos
{
    class Triangulos : ITriangulos
    {
        private
        double Base;
        double Altura;
        double Hipotenusa;
        double Area;
        double Perimetro;

        
        public Triangulos()
        {
            Base = 0;
            Altura = 0;
            Hipotenusa = 0;
        }

        public Triangulos(double Base, double Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }

        public Triangulos(double Base, double Altura, double Hipotenusa)
        {
            this.Base = Base;
            this.Altura = Altura;
            this.Hipotenusa = Hipotenusa;
        }

        public static Triangulos ComparaArea(Triangulos T1, Triangulos T2)
        {
            if (T1.GetArea() > T2.GetArea())
            {
                return T1;
            }
            return T2;
        }



        public void CalculaArea()
        {
            this.Area = (Base * Altura) / 2;
        }

        public void CalculaHipotenusa()
        {
            this.Hipotenusa = Math.Round(Math.Sqrt(Math.Pow(Base, 2) + Math.Pow(Altura, 2)),2);
        }

        public void CalculaPerimetro()
        {
            this.Perimetro = Base + Altura + Hipotenusa;
        }

        public double GetAltura()
        {
            return Altura;
        }

        public double GetArea()
        {
            return Area;
        }

        public double GetBase()
        {
            return Base;
        }

        public double GetHipotenusa()
        {
            return Hipotenusa;
        }

        public double GetPerimetro()
        {
            return Perimetro;
        }
    }
}
