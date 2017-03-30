using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisWillBeTested
{
    public class CalculAnibal
    {
        public Decimal PrimeraNota { get; set; }
        public Decimal SegundaNota { get; set; }
        public Decimal TerceraNota { get; set; }
        public Decimal Nota { get; set; }

        public void Calcular()
        {
            Nota = ((PrimeraNota * 30) + (SegundaNota * 30) + (TerceraNota * 40)) / 100;
        }
    }
}
