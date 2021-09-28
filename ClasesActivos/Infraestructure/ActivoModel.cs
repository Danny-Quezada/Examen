using ClasesActivos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesActivos.Infraestructure
{
   public class ActivoModel
    {
       public ActivoFijo[] activos { get; set; }
      
        public void Add(ActivoFijo Activo)
        {
            if (Activo == null)
            {
                throw new ArgumentNullException(nameof(Activo));
            }
            if (activos == null)
            {
                activos = new ActivoFijo[1];
                activos[0] = Activo;
            }
            else
            {
                ActivoFijo[] temp = new ActivoFijo[activos.Length + 1];
                Array.Copy(activos,temp,activos.Length);
                temp[temp.Length - 1] = Activo;
                activos = temp;
            }
        }
        public decimal[] SDA(decimal ValorActivo,decimal ValorResidual,int vidaUtil)
        {
            int Suma = 0;
            decimal[] depreciacion=new decimal[vidaUtil];
            
            for(int i=1; i <=vidaUtil; i++)
            {
                Suma += i;
            }
            for(int i = 0; i < vidaUtil; i++)
            {
                decimal a = (i+1)*(ValorActivo - ValorResidual);
               
                decimal total = a / Suma;
                
                depreciacion[i] = total;
            }
            return depreciacion;
        }


    }
}
