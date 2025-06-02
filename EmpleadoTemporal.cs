using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W
{
    internal class EmpleadoTemporal : Empleado
    {
        public int HorasExtra { get; set; }
        public override double CalcularSueldo()
        {
            return SueldoBase + (HorasExtra * 100);
        }
    }
}
