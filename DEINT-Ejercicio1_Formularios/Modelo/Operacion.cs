using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Ejercicio1_Formularios.Modelo
{
    internal class Operacion
    {
        protected int valor1;

        public int Valor1 { 
            get { return valor1; }
            set { valor1 = value; }
        }

        protected int valor2;
        
        public int Valor2 { 
            get { return valor2; }
            set { valor2 = value; }
        }

        protected int resultado;

        public int Pesultado { 
            get { return resultado; }
            set { resultado = value; }
        }
    }
}
