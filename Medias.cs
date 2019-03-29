using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace automatizar_pruebas_unitarias_2019_Arcoiris69 {
    // Clase media
    class Medias {

        /**
         * Calcula y regresa la media artimética
         */
        public static double mediaAritmetica(params int[] vals) 
        { 
            double sum = 0;
            double result = 0;
            for (int i = 0; i < vals.Length; i++)
            {
                sum += vals[i];
                result = sum / vals.Length;
            }
            return Math.Truncate(10000 * result)  / 10000;
        }

        /**
         * Calcula y regresa la raíz enésima = x^(1/n)
         */
        private static double raizEnesima(double x, int n)
        {
            double result = 0;
            result = Math.Pow(x, 1 / n);
            return Math.Truncate(10000 * result)  / 10000;
        }

        /**
         *  Usa raizEnesima para calcular y regresar la media geométrica
         */
        public double mediaGeometrica(params int[] vals) 
        {
             double mult = 1;
            for (int i = 0; i < vals.Length; i++)
            {
                mult *= vals[i];
            }
            return raizEnesima(mult, vals.Length);
        }

        /**
         * Este método no está implementado.
         */
        public static double mediaArmonica(params int[] vals) 
        {
            double sum = 0;
            for (int i = 0; i < vals.Length; i++)
            {
                sum += 1 / vals[i];
            }
            return vals.Length / sum; 
        }
    }
}
