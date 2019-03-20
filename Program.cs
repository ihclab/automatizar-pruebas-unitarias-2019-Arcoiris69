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
            string Rline ="";
            int contador = 0;
            while ((Rline = sr.ReadLine()) != null){
                sr.ReadLine();
                System.Console.WriteLine(Rline);
                contador++;
                }
            sr.Close();
            System.Console.ReadLine();
            }
        }
    }

