// See https://aka.ms/new-console-template for more information
/* Console.WriteLine("Hello, World!"); */

using FabricaDePersonajes;
using FabricaDeEnemigos;
using persistenciaDatos;
public class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        /* Personaje personaje2 = new Personaje(1,10);
        Personaje personaje3 = new Personaje(3,10);
        Personaje personaje4 = new Personaje(5,10);
 */
        /* Console.WriteLine("\nDatos del Personaje:");
        Player.MostrarPersonaje();
 */
        /* Console.WriteLine("\nDatos del Personaje: 1");
        personaje2.MostrarPersonaje();

        Console.WriteLine("\nDatos del Personaje: 3");
        personaje3.MostrarPersonaje();

        Console.WriteLine("\nDatos del Personaje: 4");
        personaje4.MostrarPersonaje(); */

        // Crear un arreglo de listas de personajes
        /* List<Enemigo>[] grupoDeEnemigos = new List<Enemigo>[4];
        grupoDeEnemigos[0] = CargarListasDePersonajes(3,1, 1);
        grupoDeEnemigos[1] = CargarListasDePersonajes(3,3, 2);
        grupoDeEnemigos[2] = CargarListasDePersonajes(3,4, 3);
        grupoDeEnemigos[3] = CargarListasDePersonajes(1,6, 4); */
        //Personaje personajeRamdom = grupoDeEnemigos[1][2];  // si se puede, hacerlo de eta manera 
        
        /* for (int i = 0; i < grupoDeEnemigos.Length; i++)
        {
            List<Enemigo> perso = grupoDeEnemigos[i];
            foreach (var pers in perso)
            {
                Console.WriteLine("\n\nMostrado de los Datos del Enemigo["+i+"]["+i+"]"); //puse i pero lo importante es que si funciona
                Console.WriteLine("Nombre: " + pers.Nombre);
                Console.WriteLine("Apodo: " + pers.Apodo);
                Console.WriteLine("Carrera: " + pers.Carrera);
                Console.WriteLine("Velocidad: " + pers.Velocidad);
                Console.WriteLine("Destreza: " + pers.Destreza);
                Console.WriteLine("Nivel: " + pers.Nivel);
                Console.WriteLine("Memoria: " + pers.Memoria);
                Console.WriteLine("Talemto: " + pers.Talento);
                Console.WriteLine("Salud: " + pers.Salud);
            }
        } */  //Bloque de código para mostrar el array de listas de enemigos

        //Creo una funcion para seleccionar un enemigo valiendome del nivel de personaje y de el array grupoDePersonajes
        /* Enemigo Enemigo1 = SeleccionarEnemigo(Player.Nivel, grupoDeEnemigos);
        Console.WriteLine("\n\nDatos Del Enemigo");
        Enemigo1.MostrarPersonaje(); */

        PersonajesJson manejoDeDatos = new PersonajesJson();
        /* manejoDeDatos.GuardarEnemigos("Enemigos", grupoDeEnemigos);

        manejoDeDatos.GuardarPlayer("Player", player); */
        bool existeResultado = manejoDeDatos.Existe("Enemigos"); 

        if (manejoDeDatos.Existe("Enemigos"))
        {
            Console.WriteLine("\nMostrado de los Datos de los Enemigos\n");
            Console.WriteLine("**************************************\n");
            List<Enemigo>[] GrupoEnemigos = manejoDeDatos.LeerEnemigos("Enemigos");
            for (int i = 0; i < GrupoEnemigos.Length; i++)
            {
                foreach (var enemigo in GrupoEnemigos[i])
                {
                    enemigo.MostrarPersonaje();
                    Console.WriteLine("\n");
                }
            }
        } else {
            // Crear un arreglo de listas de personajes
            List<Enemigo>[] grupoDeEnemigos = new List<Enemigo>[4];
            grupoDeEnemigos[0] = CargarListasDePersonajes(3, 1, 1, 10);
            grupoDeEnemigos[1] = CargarListasDePersonajes(3, 2, 3, 10);
            grupoDeEnemigos[2] = CargarListasDePersonajes(3, 3, 4, 10);
            grupoDeEnemigos[3] = CargarListasDePersonajes(1, 4, 6, 10);

            //Muestro los enemigos
            Console.WriteLine("\nMostrado de los Datos de los Enemigos Creados\n");
            Console.WriteLine("**************************************\n");
            
            for (int i = 0; i < grupoDeEnemigos.Length; i++)
            {
                foreach (var enemigo in grupoDeEnemigos[i])
                {
                    enemigo.MostrarPersonaje();
                    Console.WriteLine("\n");
                }
            }
        }

        if (manejoDeDatos.Existe("Player"))
        {
            //Console.WriteLine("\nEl archivo si existe de player si existe");
            Personaje playerr = manejoDeDatos.LeerPlayer("Player");
            Console.WriteLine("Mostrado de Player:\n");
            playerr.MostrarPersonaje();
        } else {
            Console.WriteLine("Cargado de los datos del personaje: ");
            Personaje playerr = CrearPersonajePlayer();
            Console.WriteLine("Mostrado de Player:");
            playerr.MostrarPersonaje();
        }
    }

    static Personaje CrearPersonajePlayer()
    {
        Personaje nuevoPersonaje = new Personaje();

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

    static List<Enemigo> CargarListasDePersonajes(int CantVueltas,  int nivel, int minRamdom, int maxRamdom)
    {
        Random random = new Random();
        // Crear una listas de personajes
        List<Enemigo> ListaDePersonajes = new List<Enemigo>();
        
        // Inicializar cada elemento del arreglo como una nueva lista vacía, si no lo hago: "NullReferenceException"
        for (int i = 0; i < ListaDePersonajes.Count; i++)
        {
            ListaDePersonajes = new List<Enemigo>();
        }



        for (int i = 0; i < CantVueltas; i++)
        {
            ListaDePersonajes.Add(new Enemigo());
            ListaDePersonajes[i].Nivel = nivel;  //Mofico atributo por atributo de cada clase para solucionar el problema del constructor parametrizado
            ListaDePersonajes[i].Velocidad = random.Next(minRamdom, maxRamdom);
            ListaDePersonajes[i].Destreza = random.Next(minRamdom, maxRamdom);
            ListaDePersonajes[i].Memoria = random.Next(minRamdom, maxRamdom);
            ListaDePersonajes[i].Talento = random.Next(minRamdom, maxRamdom);
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

