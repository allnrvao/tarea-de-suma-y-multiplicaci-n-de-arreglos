using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentasporComision.Clases
{
    internal class SalarioDeVendedores
    {
        private const int PagoFijo = 200;
        private const double Comision = 0.09;

        public int CalcularSalario(int ventasBrutas)
        {
            return (int)(PagoFijo + (ventasBrutas * Comision));
        }
    }
}
