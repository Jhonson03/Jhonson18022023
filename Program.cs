using Jhonson18022023.Entidades;
using Jhonson18022023.Negocio;

Datos datos = new Datos();
ClsDatos clsDatos = new ClsDatos();
Console.WriteLine(@"Bienvenido a su contador de caracteres
A continuación ingrese su palabra o frase, ten en cuenta que los espacios se toman en cuentan");

datos.datos = Console.ReadLine();

Console.WriteLine($"Su frase o palabra contiene: {clsDatos.Contador(datos)} caracteres");