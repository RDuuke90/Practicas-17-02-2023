/**
 * Iniciar 2 variables de tipo entero y evaluar si la primera es mayoro la segunda es mayor o son iguales
 * 
 */

// Definimos las variables de tipo entera con un valor asignado

Console.WriteLine("Ingrese el número 1");
int Number1 = Int32.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el número 2");
int Number2 = Int32.Parse(Console.ReadLine());

// Usamos el metodo if para evaluar si la primera es mayor que la segunda con el operador >

if (Number1 > Number2) {
    Console.WriteLine("El número 1 :"+Number1+" es mayor que el número 2 : "+Number2);
    Environment.Exit(Environment.ExitCode);
    
// Usamos el metodo if para evaluar si la segunda es mayor que la primera con el operador <
} 
if (Number1 < Number2) {
    Console.WriteLine("El número 2 :"+Number2+" es mayor que el número 1 : "+Number1);
    Environment.Exit(Environment.ExitCode);

}
Console.WriteLine("Los números son iguales");
Environment.Exit(Environment.ExitCode);

