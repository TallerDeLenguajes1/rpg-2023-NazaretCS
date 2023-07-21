// See https://aka.ms/new-console-template for more information
/* Console.WriteLine("Hello, World!"); */

using EspacioPersonajes;
public class Program
{
    static void Main()
    {
        Personaje personaje1 = CrearPersonajePlayer();
        Personaje personaje2 = new Personaje(1,10);
        Personaje personaje3 = new Personaje(3,10);
        Personaje personaje4 = new Personaje(5,10);

        Console.WriteLine("\nDatos del Personaje:");
        personaje1.MostrarPersonaje();

        Console.WriteLine("\nDatos del Personaje: 1");
        personaje2.MostrarPersonaje();

        Console.WriteLine("\nDatos del Personaje: 3");
        personaje3.MostrarPersonaje();

        Console.WriteLine("\nDatos del Personaje: 4");
        personaje4.MostrarPersonaje();
    }

    static Personaje CrearPersonajePlayer()
    {
        Personaje nuevoPersonaje = new Personaje(1,10);

        Console.Write("Ingrese el nombre del personaje: ");
        nuevoPersonaje.Nombre = Console.ReadLine();

        Console.Write("Ingrese el apodo del personaje: ");
        nuevoPersonaje.Apodo = Console.ReadLine();

        Console.Write("Ingrese la carrera del personaje: ");
        nuevoPersonaje.Carrera = Console.ReadLine();

        Console.Write("Ingrese la fecha de nacimiento del personaje (yyyy-MM-dd): ");
        nuevoPersonaje.FechaNacimiento = DateTime.Parse(Console.ReadLine());

        return nuevoPersonaje;
    }
}