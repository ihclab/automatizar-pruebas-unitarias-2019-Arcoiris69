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
            StreamReader sr =
            new StreamReader(@"C:\Users\Luis Espindola\Desktop\IHC\automatizar-pruebas-unitarias-2019-Arcoiris69\CasosPrueba.txt");
            string Rline = "";
            int j = 0;
            string[,] str = new string[20, 4];
            string[] vect = null;
            
            while ((Rline = sr.ReadLine()) != null)
            {

                //System.Console.WriteLine(Rline);
                vect = Rline.Split(":");
                for (int i = 0; i <= vect.Length - 1; i++)
                {
                    str[j, i] = vect[i];
                    Console.Write(str[j, i].ToString() + " ");
                }
                j++;
                System.Console.WriteLine(" ");
            }
            sr.Close();
            
        }
    }
}

