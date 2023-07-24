// See https://aka.ms/new-console-template for more information
/* Console.WriteLine("Hello, World!"); */

using FabricaDePersonajes;
using FabricaDeEnemigos;
public class Program
{
    static void Main(string[] args)
    {
        Personaje Player = CrearPersonajePlayer();
        /* Personaje personaje2 = new Personaje(1,10);
        Personaje personaje3 = new Personaje(3,10);
        Personaje personaje4 = new Personaje(5,10);
 */
        Console.WriteLine("\nDatos del Personaje:");
        Player.MostrarPersonaje();

        /* Console.WriteLine("\nDatos del Personaje: 1");
        personaje2.MostrarPersonaje();

        Console.WriteLine("\nDatos del Personaje: 3");
        personaje3.MostrarPersonaje();

        Console.WriteLine("\nDatos del Personaje: 4");
        personaje4.MostrarPersonaje(); */

        // Crear un arreglo de listas de personajes
        List<Enemigo>[] gruposDePersonajes = new List<Enemigo>[3];
        gruposDePersonajes[0] = CargarListasDePersonajes(3,1);
        gruposDePersonajes[1] = CargarListasDePersonajes(3,3);
        gruposDePersonajes[2] = CargarListasDePersonajes(3,5);
        
        //Personaje personajeRamdom = gruposDePersonajes[1][2];  // si se puede, hacerlo de eta manera 
        
       /*  for (int i = 0; i < gruposDePersonajes.Length; i++)
        {
            List<Personaje> perso = gruposDePersonajes[i];
            foreach (var pers in perso)
            {
                Console.WriteLine("\n\nMostrado de los Datos del Enemigo["+i+"]["+i+"]"); //puse i pero lo importante es que si funciona
                Console.WriteLine("Nombre: " + pers.Nombre);
                Console.WriteLine("Apodo: " + pers.Apodo);
                Console.WriteLine("Carrera: " + pers.Carrera);
                Console.WriteLine("Velocidad: " + pers.Velocidad);
                Console.WriteLine("Destreza: " + pers.Destreza);
                Console.WriteLine("Nivel: " + pers.Nivel);
                Console.WriteLine("Apunte: " + pers.Apuntes);
                Console.WriteLine("Memoria: " + pers.Memoria);
                Console.WriteLine("Talemto: " + pers.Talento);
                Console.WriteLine("Salud: " + pers.Salud);
            }
        } */  //Bloque de código para mostrar el array de listas de enemigos


        //Creo una funcion para seleccionar un enemigo valiendome del nivel de personaje y de el array grupoDePersonajes
        Enemigo Enemigo1 = SeleccionarEnemigo(Player.Nivel, gruposDePersonajes);
        Console.WriteLine("\n\nDatos Del Enemigo");
        Enemigo1.MostrarPersonaje();

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
        nuevoPersonaje.FechaNacimiento = DateTime.Parse(Console.ReadLine()); // manejar la insercion de una fecha erronea

        return nuevoPersonaje;
    }

    static List<Enemigo> CargarListasDePersonajes(int CantVueltas, int minRamdom)
    {
        // Crear una listas de personajes
        List<Enemigo> ListaDePersonajes = new List<Enemigo>();
        
        // Inicializar cada elemento del arreglo como una nueva lista vacía, si no lo hago: "NullReferenceException"
        for (int i = 0; i < ListaDePersonajes.Count; i++)
        {
            ListaDePersonajes = new List<Enemigo>();
        }

        for (int i = 0; i < CantVueltas; i++)
        {
            ListaDePersonajes.Add(new Enemigo(minRamdom,10));
        }
        return ListaDePersonajes;
    }

    
    //Creo una funcion para seleccionar un enemigo valiendome del nivel de personaje y de el array grupoDePersonajes

    static Enemigo SeleccionarEnemigo(int NivelPersonaje, List<Enemigo>[] GrupoPersonajes)
    {
        Random random = new Random();
        int numeroEnemigoAleatorio = random.Next(3); 
        return (GrupoPersonajes[NivelPersonaje][numeroEnemigoAleatorio]);
    }
}

