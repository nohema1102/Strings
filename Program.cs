using System;
using System.Collections.Generic;
namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Que voy a buscar, por qué lo voy a reemplazar
            string valor1 = "Hola";
            //string valor2 = "john" no hacer eso
            string valor2 = valor1.Replace("a","4");
            Console.WriteLine(valor1);
            Console.WriteLine(valor2);


            Console.WriteLine("----------------");

            valor1 = "Hola Mundo";
            valor2 = valor1.Replace("o", "0");
            Console.WriteLine(valor1);
            Console.WriteLine(valor2);

            Console.WriteLine("----------------");

            valor1 = "Hola Mundo";
            valor2 = valor1.Replace("Mundo", "Alumnos");
            Console.WriteLine(valor1);
            Console.WriteLine(valor2);

             Console.WriteLine("----------------");

             valor1 = "474+621";
             string[] valor2Arreglo = valor1.Split("+");
             Console.WriteLine(valor1);
             // Un string se muestra como System.String[]
             //Console.WriteLine(valor2Arreglo);

             foreach (string value in valor2Arreglo)
             {
                 Console.WriteLine(value);
             }

              Console.WriteLine("----------------");

                valor1 = "474+621+40+32+10";
                valor2Arreglo = valor1.Split("+");

                Console.WriteLine(valor1);
                Console.WriteLine("El resultado del split tiene " + valor2Arreglo.Length + " strings");
                foreach (string value in valor2Arreglo)
             {
                 Console.WriteLine(value);
             }

             Console.WriteLine("----------------");

             valor1 = "fresa mora frambuesa";
             valor2Arreglo = valor1.Split(" ");
             Console.WriteLine(valor1);
               foreach (string value in valor2Arreglo)
             {
                 Console.WriteLine(value);
             } 
             MostrarEjemploSplit("fresa mora frambuesa", "m");
             MostrarEjemploSplit("fresa mora frambuesa", " ");
             MostrarEjemploSplit("fresa mora frambuesa".Replace(" ", " "), " ");

             MostrarEjemploSplit("1 +4 + 6 +3+5 + 22" , "+"); 
             //replace (" ", "") - borrar espacios
             MostrarEjemploSplit("1 +4 + 6 +3+5 + 22".Replace(" ", ""),"+");

             MostrarEjemploSplit("fresa mora frambuesa", "mora");

             Console.WriteLine("---------------");  

             valor1 = "fresa";
             valor2 = valor1.Trim();
             Console.WriteLine(valor1);
             Console.WriteLine(valor2);

             Console.WriteLine("-----------"); 

             valor1 = "Peter, Albert, jOHN";
             valor2 = valor1.ToLower();
             Console.WriteLine(valor1);
             Console.WriteLine(valor2);

             Console.WriteLine("-------------"); 

             valor1 = "Peter, Albert, jOHN";
             valor2 = valor1.ToUpper();
             Console.WriteLine(valor1);
             Console.WriteLine(valor2);

              Console.WriteLine("-------------"); 

              valor1 = "Peter, Albert, John";
              //valor2 = value1.reverse();
              //convertir string a char[]
              char[] chararreglo = valor1.ToCharArray();
              //invertir (reverse) el array
              Array.Reverse (chararreglo);
              //crear un nueo string a partir del char[]
              valor2 = new string( chararreglo );
              Console.WriteLine(valor1);
              Console.WriteLine(valor2);

              Console.WriteLine("-------------"); 

              valor1 = "Hola Mundo!";
              string substring1 = valor1.Substring(0, 4);
              string substring2 = valor1.Substring(2, 4);
              string substring3 = valor1.Substring(8, 3);
              int indexOf = valor1.IndexOf("M");
              int indexOf2 = valor1.IndexOf("o");
              int lastIndexOf = valor1.LastIndexOf("o");
              Console.WriteLine(valor1);
              Console.WriteLine(substring1);
              Console.WriteLine(substring2);
              Console.WriteLine(substring3);
              Console.WriteLine("indexOf: " + indexOf);
              Console.WriteLine("indexOf2: " + indexOf2);
              Console.WriteLine("lastIndexOf: " + lastIndexOf);

              Console.WriteLine("------------");

              List<string> nombres = new List<string>();
              nombres.Add("Peter");
              nombres.Add("Albert");
              nombres.Add("John");

              Console.WriteLine("Peter? " + nombres.Contains("Peter")); //true
              Console.WriteLine("bert, Jo? " + nombres.Contains("bert, Jo"));//false

              //ejemplo de uso comun

              if (nombres.Contains("Peter"))
              {
                 //Hacer algo en caso de que si lo contenga 
              }

              Console.WriteLine("----------");

              valor1 = "Peter, Albert, John";
              Console.WriteLine("Peter? " + valor1.Contains("Peter"));//true
              Console.WriteLine("bert, Jo? " + valor1.Contains("bert, Jo?"));//true
              Console.WriteLine("peter? " + valor1.Contains("peter"));//false
              Console.WriteLine("peter? " + valor1.ToLower().Contains("peter"));

            Console.WriteLine("----------");

            valor1 = "Peter, Albert, John";
            //"Peter, Albert, John" -> "John, Albert, Peter"
            //1. Separar en palabras
            //2. invertir orden de palabras
            valor2Arreglo = valor1.Split(", ");
             Array.Reverse(valor2Arreglo);
             foreach (string val in valor2Arreglo)
             {
                Console.WriteLine(val); 
             }
             valor2 = string.Join(", ", valor2Arreglo);
             //Utilizando este separador, junta el siguiente array
             Console.WriteLine(valor2);

             Console.WriteLine("--------");

             valor1 = "John";
             valor2 = valor1.ToLower();
             //John -> john
            //diagonal inversa (escapar caracteres) transforma caracteres especiales
            //en caracteres normales
             Console.WriteLine("\"John\" -> \"john\"");
             //Indicamos posicion de las variables y despues pasamos su valores
             Console.WriteLine("\"{0}\" -> \"{1}\"", valor1, valor2);
             //Indicamos exactamente la posicion en donde van las variables
             //Nota: requiere un signo de $ antes del string
             Console.WriteLine($"\"{valor1}\" -> \"{valor2}\"");
 
              
        }
        //public - accesible desde cualquier archivo
        //static - se puede mandar a llamar desde otro metodo (en este caso, el Main)
        //void - no devuelve nada (solamente imprime informacion en la consola)
        public static void MostrarEjemploSplit(string valor, string separador)
        {
            string[] valorArreglo = valor.Split(separador);
            Console.WriteLine(valor);
            Console.WriteLine("El resultado del split tiene " + valorArreglo.Length + " strins");
            foreach (string val in valorArreglo)
             {
                 Console.WriteLine(val);
             } 

        }
    }
}
