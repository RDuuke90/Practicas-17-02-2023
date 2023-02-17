/**
 * Dado un número de dos cifras entregar el inverso del número
 * Ejemplo: 12 se entrega 21
 * 
 */

//Definimos las variables necesarias de tipo entera

int Numero, Numeroinvertido, Decena, Unidad;

Numero = Int32.Parse(Console.ReadLine());

//Obtenemos la decena del número con la division de 10, como es de tipo entero la parte decimal es omitida.
Decena = Numero/10;

//Dividimos el numero y el residuo siempre sera la parte de de unidad
//Ejemplo 12/10 el residuo siempre sera 0.2
Unidad = Numero % 10;


//Movemos la (,) uno a la derecha para eliminar el 0, y le sumamos la decena
Numeroinvertido = (Unidad * 10) + Decena;

Console.WriteLine("El numero ingresado es: "+Numero+", el invertido es: "+Numeroinvertido);
