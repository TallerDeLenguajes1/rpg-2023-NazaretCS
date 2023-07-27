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

        //Realizo una funcion para verificar la existencia del enemigo
        List<Enemigo>[] grupoDeEnemigos = VerificarExistenciaDeEnemigos();

        //Realizo una funcion para verificar la existencia de un player
        Personaje player = VerificarExistenciaPlayer();

        Console.WriteLine("\nCALCULO EL DAÑO QUE PROVOCARA EL PALYER");
        double danioProvocado = player.danioProvocado();
        Console.WriteLine("El daño es de: " + danioProvocado);
        

        //Selecciono el primer enemigo del player
        Enemigo enemigoNivel1 = SeleccionarEnemigo(1, grupoDeEnemigos);  // si se puede, hacerlo de eta manera 
        enemigoNivel1.MostrarPersonaje();
        Console.WriteLine("\nCALCULO EL DAÑO QUE PROVOCARA EL Enemigo");
        double danioProvocado2 = enemigoNivel1.danioProvocado();
        Console.WriteLine("El daño es de: " + danioProvocado2);

        //Desarrollo la funcion convate:
        bool ResultadoPelea = Pelea(player, enemigoNivel1);
        if (ResultadoPelea)
        {
            player.actualizaSalud(100);
            Console.WriteLine("\nFelisidades sobrevisite a la materia: Salud Restaurada" + player.Salud);
            // realizar las actualizaciones / bonificaciones
            DarBonos(player);
            Console.WriteLine("\nPreparando la siguiente materia: ");

            

            Enemigo enemigoNivel2 = SeleccionarEnemigo(2, grupoDeEnemigos);
            bool ResultadoPelea2 = Pelea(player, enemigoNivel2);

            if (ResultadoPelea2)
            {
                player.actualizaSalud(100);
                Console.WriteLine("\nFelisidades sobrevisite a la materia: Salud Restaurada" + player.Salud);
                // realizar las actualizaciones / bonificaciones
                DarBonos(player);
                Console.WriteLine("\nPreparando la siguiente materia: ");

                Enemigo enemigoNivel3 = SeleccionarEnemigo(2, grupoDeEnemigos);
                bool ResultadoPelea3 = Pelea(player, enemigoNivel3);

                if (ResultadoPelea3)
                {
                    player.actualizaSalud(100);
                    Console.WriteLine("\nFelisidades sobrevisite a la materia: Salud Restaurada" + player.Salud);
                    // realizar las actualizaciones / bonificaciones
                    DarBonos(player);

                    Console.WriteLine("\nPREPARANDO EL PROYECTO FINAL ");
                    bool ResultadoPelea4 = Pelea(player, grupoDeEnemigos[3][0]);

                    if (ResultadoPelea4)
                    {
                        Console.WriteLine("\nFelicidades GANASTE TU TITULO");
                    }
                }

            } else {
                Console.WriteLine("OBTUVISTE UN L");
                Console.WriteLine("Mejor suerte a la proxima");
                Console.WriteLine("Pelea2");
            }

        } else {
            Console.WriteLine("OBTUVISTE UN L");
            Console.WriteLine("Mejor suerte a la proxima");
            Console.WriteLine("Pelea1");
            
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

    static List<Enemigo>[] VerificarExistenciaDeEnemigos()
    {
        PersonajesJson manejoDeDatos = new PersonajesJson();
        if (manejoDeDatos.Existe("Enemigos"))
        {
            Console.WriteLine("\nMostrado de los Datos de los Enemigos\n");
            Console.WriteLine("**************************************\n");
            List<Enemigo>[] grupoDeEnemigos = manejoDeDatos.LeerEnemigos("Enemigos");
            for (int i = 0; i < grupoDeEnemigos.Length; i++)
            {
                foreach (var enemigo in grupoDeEnemigos[i])
                {
                    enemigo.MostrarPersonaje();
                    Console.WriteLine("\n");
                }
            }

            return grupoDeEnemigos;
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

            //Guardo a los enemigos Creados en el JSON correspondiente
            manejoDeDatos.GuardarEnemigos("Enemigos", grupoDeEnemigos);
            return grupoDeEnemigos;
        }
    }

    static Personaje VerificarExistenciaPlayer()
    {
        PersonajesJson manejoDeDatos = new PersonajesJson();
        if (manejoDeDatos.Existe("Player"))
        {
            //Console.WriteLine("\nEl archivo si existe de player si existe");
            Personaje playerr = manejoDeDatos.LeerPlayer("Player");
            Console.WriteLine("Mostrado de Player:\n");
            playerr.MostrarPersonaje();
            return playerr;
        } else {
            Console.WriteLine("Cargado de los datos del personaje: ");
            Personaje playerr = CrearPersonajePlayer();
            Console.WriteLine("Mostrado de Player:");
            playerr.MostrarPersonaje();

            //Guardado de los datos del player
            manejoDeDatos.GuardarPlayer("Player", playerr);
            return playerr;
        }
    }

    //retorn true si gana el player, y false en caso contrario
    static bool Pelea(Personaje player, Enemigo enemigo)
    {
        Random random = new Random();
        int i= random.Next(1,11);
        while (enemigo.Salud >= 0 && player.Salud>= 0)
        {
            if (i%2 ==0 )
            {
                //ataca la materia
                player.actualizaSalud(enemigo.danioProvocado());
                /* Console.WriteLine("\nLa salud del playes es: " + player.Salud); */
            } else {
                //ataca el player
                enemigo.actualizaSalud(player.danioProvocado());
                /* Console.WriteLine("\nLa salud de la materia es: " + enemigo.Salud); */
            }
            i++;
        }
        if (player.Salud >= 0)
        {
            Console.WriteLine("SOBREVISTE A LA MATERIA");
            return true;
        } else {
            Console.WriteLine("GANADORRRR: La mateira: \n");
            enemigo.MostrarPersonaje();
            return false;
        }
    }

    static void DarBonos(Personaje Player)
    {
        double bonoSalud = (Player.GetSalud() * 20)/100;
        double bonoAnimos = (Player.GetAnimos() * 20)/100;  //Le sumo el 20% a esos 3
        double bonoApuntes = (Player.GetApuntes() * 20)/100;

        Player.SetSalud(Player.GetSalud()+bonoSalud);
        Player.SetAnimos(Player.GetAnimos()+bonoAnimos);
        Player.SetApuntes(Player.GetApuntes()+bonoApuntes);
        Console.WriteLine("\nBONOS APLICADOS POR GANADOR");
        Player.MostrarPersonaje();
    }

   
}


//Pelean pero devo verificar porque siempre ganan las materias 