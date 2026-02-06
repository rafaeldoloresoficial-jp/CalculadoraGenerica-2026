using CalculadoraGenerica;
using System;
using System.Collections.Generic;

namespace CalculadoraGenerica
{
    // Delegado que representa una operación matemática.
    // Recibe dos valores del mismo tipo y devuelve un resultado.
    public delegate T OperacionMatematica<T>(T a, T b);

    // Clase genérica que permite trabajar con diferentes tipos de números
    // (por ejemplo int, double, decimal, etc.).
    public class CalculadoraGenerica<T>
    {
        // Lista donde se almacenan los números ingresados por el usuario.
        private List<T> numeros = new List<T>();

        // Método que permite agregar un número a la lista.
        public void AgregarNumero(T numero)
        {
            numeros.Add(numero);
        }

        // Método que ejecuta una operación matemática sobre todos los
        // números almacenados en la lista usando el delegado.
        public T EjecutarOperacion(OperacionMatematica<T> operacion)
        {
            // Se verifica que haya al menos dos números antes de operar.
            if (numeros.Count < 2)
            {
                throw new InvalidOperationException(
                    "Debe haber al menos dos números para realizar la operación."
                );
            }

            // Se toma el primer número como base del resultado.
            T resultado = numeros[0];

            // Se recorre la lista aplicando la operación al resultado acumulado.
            for (int i = 1; i < numeros.Count; i++)
            {
                resultado = operacion(resultado, numeros[i]);
            }

            // Se devuelve el resultado final de la operación.
            return resultado;
        }
    }
}