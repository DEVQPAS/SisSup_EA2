using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo_Triangulos
{
    interface ITriangulos
    {
        void CalculaArea();
        void CalculaPerimetro();
        void CalculaHipotenusa();

        double GetBase();
        double GetAltura();
        double GetArea();
        double GetPerimetro();
        double GetHipotenusa();
    }
}
