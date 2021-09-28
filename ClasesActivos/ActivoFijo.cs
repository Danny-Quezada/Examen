using ClasesActivos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesActivos
{
    public class ActivoFijo
    {


        public int Id { get; set; }
        public string codigo { get; set; }
        public string descripcion { get; set;}

        public decimal ValorActivo { get; set; }

        public decimal ValorResidual { get; set; }
        public int VidaUtil { get; set; }
        public DateTime FechaDeAdquisicion { get; set; }

        public EnumsTipoActivo TipoActivo { get; set; }



    }
}
