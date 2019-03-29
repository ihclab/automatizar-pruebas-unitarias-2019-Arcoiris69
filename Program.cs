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
            int count = 1;
            
            try
            {
            while ((Rline = sr.ReadLine()) != null)
            {
                try
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
                } catch (Exception ex) {
                    Console.WriteLine(ex.Message + "\n");
            }
                
            }
            //Ciclo para obtener el vector o los datos de las entradas
            sr.Close();
            

            for(int i = 0; i <= 19; i++)
            {
                try
                {
                int[] vectint = null;
                double sal = 0;
                
                data = str[i,1];
                entrada = str[i,2];
                salida = str[i,3];
                datos = entrada.Split(" ");
                //Convierte los datos a su tipo de dato

                vectint = Array.ConvertAll(datos, int.Parse);
                sal = Convert.ToDouble(salida);
                double result;
                Console.Write(count + ".-");
                count++;
                if(data == "mediaAritmetica"){
                    result = Medias.mediaAritmetica(vectint);
                    result = Math.Truncate(10000 * result)  / 10000;
                    
                    if(sal == result)
                    {
                        Console.WriteLine("Éxito");
                    }
                    else
                        Console.WriteLine("Fallo");
                }
                else if(data == "mediaGeometrica")
                {
                    
                   result = media.mediaGeometrica(vectint);
                   result = Math.Truncate(10000 * result)  / 10000;
                    
                   if(sal == result)
                    {
                        Console.WriteLine("Éxito");
                    }
                    else
                        Console.WriteLine("Fallo");
                }
                else if(data == "mediaArmonica")
                {
                    result = Medias.mediaAritmetica(vectint);
                    result = Math.Truncate(10000 * result)  / 10000;
                    if(sal == result)
                    {
                        Console.WriteLine("Éxito");
                    }
                    else
                        Console.WriteLine("Fallo");
                }
                else{
                    Console.WriteLine("Fallo");
                }
                } catch (Exception ex) {
                    Console.WriteLine(count++ +".-Exepcion");
                

                }
            }
            
            } catch (Exception ex) {
                    Console.WriteLine(ex.Message);
            }
        }
    }
}

