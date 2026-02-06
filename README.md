(+ -)Calculadora Genérica en C# (/ x)

1-Descripción  de la aplicación:
La  aplicación es una calculadora creada en C# para permitir al  usuario ingresar números en una lista y realizar operaciones matemáticas como suma, resta, multiplicación y división usando un menú en consola. 
El programa maneja errores comunes para evitar fallos durante la ejecución.

2-Explicación de los métodos implementados:
Método para agregar Numero (T numero)
Permite agregar números a la lista interna de la calculadora.
Metodo para ejecutar Operación (OperacionMatematica<T> operacion)
Ejecuta una operación matemática sobre todos los números almacenados en la lista utilizando un delegado.
Métodos Sumar, Restar, Multiplicar, Dividir
Métodos que realizan las operaciones matemáticas básicas y son enviados como parámetros al delegado.

3-Excepciones en su manejo:
El programa controla las siguientes excepciones:
•	FormatException: ocurre cuando el usuario introduce un valor que no es numérico.
•	DivideByZeroException: ocurre cuando se intenta dividir entre cero.
•	InvalidOperationException: ocurre cuando se intenta realizar una operación con menos de dos números en la lista.


4- Genéricos y delegados  en uso: 
Genéricos:
Se utiliza la clase CalculadoraGenerica<T> para permitir trabajar con diferentes tipos de datos numéricos sin modificar el código.
Delegados:
Se utiliza el delegado OperacionMatematica<T> para representar operaciones matemáticas y permitir que distintos métodos se ejecuten de forma flexible.
5- Cómo ejecutar el programa
1.	Abrir el proyecto en Visual Studio.
2.	Compilar el programa.
3.	Ejecutar la aplicación.
4.	Usar el menú para agregar números y realizar operaciones, con las observaciones indicadas.
