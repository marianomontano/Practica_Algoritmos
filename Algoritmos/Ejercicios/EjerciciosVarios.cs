using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmos.Ejercicios
{
    public static class EjerciciosVarios
    {
        //How to Print duplicate characters in a String
        public static string LetrasDuplicadas(string input1, string input2)
        {
            StringBuilder output = new StringBuilder();

            var array1 = input1.ToCharArray();
            var array2 = input2.ToCharArray();

            //tomo letra de la primera palabra
            for (int i = 0; i < array1.Length; i++)
            {
                //comparo con letra de la segunda palabra
                for (int j = 0; j < array2.Length; j++)
                {
                    //si son iguales y no está en la lista de resultado
                    if (array1[i] == array2[j] && output.ToString().Contains(array1[i].ToString()) == false)
                    {
                        //agrego a la lista de resultado
                        output.Append(array1[i].ToString());
                    }
                }
            }

            return output.ToString();
        }

       //How to count number of words in a String
        public static int ContarPalabrasEnCadena(string input)
        {
            int resultado = 0;

            var separada = input.Split(' ');

            resultado = separada.Count();

            return resultado;
        }

        //Determine if any two integers in array sum to given integer
        public static bool SumarDosNumerosDeArray(int[] array, int suma)
        {
            bool resultado = false;
            //desde el primero hasta el anteúltimo
            for (int i = 0; i < array.Length - 1; i++)
            {
                //desde el segundo hasta el último
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == suma)
                    {
                        resultado = true;
                    }
                }
            }

            return resultado;
        }


    }
}
