using Jhonson18022023.Entidades;
using Jhonson18022023.Negocio;

Datos datos = new Datos();
ClsDatos clsDatos = new ClsDatos();
Console.WriteLine(@"----------------------------------------
 Bienvenido a su contador de caracteres
----------------------------------------

Advertencia: Si la frase que ingresa lleva espacios se contará como un caracter

Presione la tecla 'Enter' para continuar");
Console.ReadLine();

Console.WriteLine("Ingrese su frase o palabra");

datos.datos = Console.ReadLine();

Console.WriteLine($"\nSu frase o palabra contiene: {clsDatos.Contador(datos)} caracteres");