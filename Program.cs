using System;
using System.Collections;
using System.IO;


namespace automatizar_pruebas_unitarias_2019_Arcoiris69
{
    //Clase Program 
    
    class Program
    {
        
        //Main
        static void Main(string[] args)
        {
            Medias media = new Medias();
            StreamReader sr =
            new StreamReader(@"C:\Users\Luis Espindola\Desktop\IHC\automatizar-pruebas-unitarias-2019-Arcoiris69\CasosPrueba.txt");
            string Rline = "";
            int j = 0;
            string[,] str = new string[20, 4];
            string[] vect = null , datos = null;
            string entrada = "", salida = "", data = "";
            
            
            while ((Rline = sr.ReadLine()) != null)
            {
                //Vector que recibe los valores por separado (id, metodo, entrada y salidas)
                vect = Rline.Split(":");
                //Este ciclo hará que todo se almacene en una matriz o vector de dos dimenciones.
                for (int i = 0; i <= vect.Length - 1; i++)
                {
                    //Le pasa los parametros del vector a la matriz.
                    str[j, i] = vect[i];
                    //Console.Write(str[j, i].ToString() + " ");
                }
                //contador.
                j++;
                //Salto de linea para darle un bonito diseño osi osi (8.
                System.Console.WriteLine(" ");
            }
            //Ciclo para obtener el vector o los datos de las entradas
            sr.Close();
            

            for(int i = 1; i <= 20; i++)
            {
                int[] vectint = null;
                double sal = 0;
                
                data = str[i,1];
                entrada = str[i,2];
                salida = str[i,3];
                datos = entrada.Split(" ");
                vectint = Array.ConvertAll(datos, int.Parse);
                sal = Convert.ToDouble(salida);
                
                if(data == "mediaAritmetica"){
                    Medias.mediaAritmetica(vectint);
                    
                }
                else if(data == "mediaGeometrica")
                {
                    media.mediaGeometrica(vectint);
                }
                else if(data == "mediaArmonica")
                {
                    Medias.mediaAritmetica(vectint);
                }
            }
            
        }
    }
}

