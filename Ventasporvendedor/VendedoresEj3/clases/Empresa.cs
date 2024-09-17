using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventasporvendedor.models
{
    internal class Empresa
    {
        public double[,] AllVentas = new double[5, 4];
        public void AgregarVenta(Ventasx venta)
        {
            AllVentas[venta.IdProducto, venta.IdVendedor] += venta.Valor;
        }
        public double TotalVentasVendedor(int vendedor)
        {
            double total = 0;
            for (int i = 0; i < 5; i++)
            {
                total += AllVentas[i, vendedor - 1];
            }
            return total;
        }

        public double TotalVentasProducto(int producto)
        {
            double total = 0;
            for (int i = 0; i < 4; i++)
            {
                total += AllVentas[producto-1, i];
            }
            return total;
        }

        public double[,] CambVentas()
        {
            return AllVentas;
        }
    }
}
