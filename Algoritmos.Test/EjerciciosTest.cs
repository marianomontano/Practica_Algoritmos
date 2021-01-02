using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Algoritmos.Ejercicios;

namespace Algoritmos.Test
{
    public class EjerciciosTest
    {

        [Theory]
        [InlineData("hola", "ola", "ola")]
        [InlineData("para", "roca", "ar")]
        [InlineData("masa", "poco", "")]
        public void LetrasDuplicadas_DevuelveListaDeDuplicados
            (string input1, string input2, string output)
        {
            //Act
            var actual = EjerciciosVarios.LetrasDuplicadas(input1, input2);

            //Assert
            Assert.Equal(output, actual);
        }

        [Theory]
        [InlineData("Mi nombre es Mariano Montano", 5)]
        [InlineData("El perro de mi vecino se llama Tommy", 8)]
        [InlineData("Me llamo Mariano y tengo dos hijas muy hermosas que se la pasan haciendo lío", 15)]
        public void ContarPalabrasEnCadena_RetornaCantidadDePalabras(string input, int resultado)
        {
            //Act
            var actual = EjerciciosVarios.ContarPalabrasEnCadena(input);

            //Assert
            Assert.Equal(resultado, actual);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 9)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 5)]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 7)]
        public void SumarDosNumerosDeArray_RetornaVerdadero(int[] array, int resultado)
        {
            //Act
            var actual = EjerciciosVarios.SumarDosNumerosDeArray(array, resultado);

            //Assert
            Assert.True(actual);
        }

    }
}
