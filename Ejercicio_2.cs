/**
 * Inicializar dos variables de tipo string que contengan el nombre y apellido de un empleado.
 * A cual le daran un bono de 10usd por cada tarea realizada.
 * Imprimir el nombre completo con el número de tareas y el total de bono ganado.
 * 
 */

//Definimos las variables string para nombres y apellidos
Console.WriteLine("Ingresa el nombre");
string? Name = Console.ReadLine();
Console.WriteLine("Ingresa el apellido");
string? Last_Name = Console.ReadLine();
 
// Definimos las variables de tipo entera con un valor asignado
int Bonus = 10;
Console.WriteLine("Ingresa la cantidad de tareas solucionada");
int Task = Int32.Parse(Console.ReadLine());;

// Calculamos el pago que se le hace al empleado
int Pay = Bonus*Task;

Console.WriteLine($"El empleado: {Name} {Last_Name}. Que realizo {Task} tareas, obtuvo un pago de bono de: {Pay}");
