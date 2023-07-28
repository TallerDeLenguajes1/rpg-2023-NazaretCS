// See https://aka.ms/new-console-template for more information
/* Console.WriteLine("Hello, World!"); */

using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

using ChuckNorrisJokes;
using FabricaDePersonajes;
using FabricaDeEnemigos;
using persistenciaDatos;
public class Program
{
    static async Task Main(string[] args)
    {
        Console.Write(@"
        
        
        








        

        
        
        ");
        Console.Write(@"
        ███████╗░█████╗░░█████╗░██╗░░░██╗██╗░░░░████████╗░█████╗░██████╗░░░░░██████╗██╗░░░██╗██████╗░██╗░░░██╗██╗██╗░░░██╗███████╗
        ██╔════╝██╔══██╗██╔══██╗██║░░░██║██║░░░░╚══██╔══╝██╔══██╗██╔══██╗░░░██╔════╝██║░░░██║██╔══██╗██║░░░██║██║██║░░░██║██╔════╝
        █████╗░░███████║██║░░╚═╝██║░░░██║██║░░░░░░░██║░░░███████║██║░░██║░░░╚█████╗░██║░░░██║██████╔╝╚██╗░██╔╝██║╚██╗░██╔╝█████╗░░
        ██╔══╝░░██╔══██║██║░░██╗██║░░░██║██║░░░░░░░██║░░░██╔══██║██║░░██║░░░░╚═══██╗██║░░░██║██╔══██╗░╚████╔╝░██║░╚████╔╝░██╔══╝░░
        ██║░░░░░██║░░██║╚█████╔╝╚██████╔╝███████╗░░██║░░░██║░░██║██████╔╝░░░██████╔╝╚██████╔╝██║░░██║░░╚██╔╝░░██║░░╚██╔╝░░███████╗
        ╚═╝░░░░░╚═╝░░╚═╝░╚════╝░░╚═════╝░╚══════╝░░╚═╝░░░╚═╝░░╚═╝╚═════╝░░░░╚═════╝░░╚═════╝░╚═╝░░╚═╝░░░╚═╝░░░╚═╝░░░╚═╝░░░╚══════╝"
        );

        Random random = new Random();
        PersonajesJson manejoDeDatos = new PersonajesJson();
        
        Console.Write(@"
        
        
        

        ");
        
        if (manejoDeDatos.Existe("Player.json"))
        {
            Console.Write(@"
                > Player Detectado.
                > Obteniendo datos.

                > Aguarde un momento por favor...
            ");
            Thread.Sleep(5000);
            Console.Write("     Datos Cargados! Presiona una Tecla para continuar...\n");
            Console.ReadKey();
        } else {
            Console.Write(@"
                > Personalize su Estudiante:
            ");
        }
        Personaje player = VerificarExistenciaPlayer();
        
        Console.WriteLine("\n\n                   DATOS DE TU PERSONAJE:");
        player.MostrarPersonaje();

        Console.Write("\n\n\n                   Generando Enemigos...\n                   PREPARATE!!");
        List<Enemigo>[] grupoDeEnemigos = VerificarExistenciaDeEnemigos();
        Thread.Sleep(3000);
        Console.Write("\n\n                 Seleccionando Tu PRIMER ENEMIGO");
        Thread.Sleep(3000);
        Enemigo enemigoNivel1 = SeleccionarEnemigo(0, grupoDeEnemigos);
        Console.Write("\n                   Tu enemigo esta LISTO para la Lucha\n");
        Console.WriteLine("\n\n                   DATOS DE TU ENEMIGO:");
        enemigoNivel1.MostrarPersonaje();
        Console.Write("\n\n\n                   Preciona una tecla cualquiera cuando TU tambien lo estes:\n\n");
        Console.ReadKey();

        //Realizo una funcion para verificar la existencia del enemigo
        

        //Realizo una funcion para verificar la existencia de un player
        //Console.WriteLine("\nMOSTRADO DE DATOS DEL PLAYER");
        //player.MostrarPersonaje();
        //Console.WriteLine("\nCALCULO EL DAÑO QUE PROVOCARA EL PALYER");
        //double danioProvocado = player.danioProvocado();
        //Console.WriteLine("El daño es de: " + danioProvocado);
        

        //Selecciono el primer enemigo del player
          // si se puede, hacerlo de eta manera 

        /* Console.WriteLine("\n\nDatos del Primer Enemigo:");
        enemigoNivel1.MostrarPersonaje(); */
        //Console.WriteLine("\n\nCALCULO EL DAÑO QUE PROVOCARA EL Enemigo");
        double danioProvocado = 0;
        //Console.WriteLine("El daño es de: " + danioProvocado2);

        graficosPelea();
        Console.ReadKey();
        //Desarrollo la funcion convate:
        bool ResultadoPelea = Pelea(player, enemigoNivel1);
        if (ResultadoPelea)
        {
            Console.Write(@"



            **************************************************************************************
            *                                                                                    *
            *           ███████████████████████████████████████████████████████████████          *
            *           █▄─▄▄─█▄─▄▄─█▄─▄███▄─▄█─▄▄▄─█▄─▄█▄─▄▄▀██▀▄─██▄─▄▄▀█▄─▄▄─█─▄▄▄▄█          *
            *           ██─▄████─▄█▀██─██▀██─██─███▀██─███─██─██─▀─███─██─██─▄█▀█▄▄▄▄─█          *
            *           ▀▄▄▄▀▀▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▀▄▄▄▄▄▀▄▄▄▀▄▄▄▄▀▀▄▄▀▄▄▀▄▄▄▄▀▀▄▄▄▄▄▀▄▄▄▄▄▀          *
            *                                                                                    *
            *                             Player: {0}                                            *
            *                               VENCISTE EN TU PRIMER PELEA                          *
            *                                                                                    *
            *                                                                                    *
            **************************************************************************************
            ",player.Nombre);
            /* Console.WriteLine("\n\nMostrado de datos del personaje:");
            player.MostrarPersonaje(); */
            //player.SetSalud(1000);
            //Console.WriteLine("\nFelisidades sobrevisite a la materia: Salud Restaurada" + player.Salud);
            // realizar las actualizaciones / bonificaciones
            Console.WriteLine("\n\n\n              > Aplicando Bonos Por vencedor");
            Thread.Sleep(1000);
            Console.WriteLine("               > Cada vez que le ganes a una materia tus avilidades seran potenciadas!");
            Thread.Sleep(1000);
            DarBonos(player);
            //player.MostrarPersonaje();
            Console.WriteLine("\n\n\n\n             PREPARANDO TU SIGUIENTE ENEMIGA... \n             Pulsa una tecla cuando estes listo para conocerla");
            Console.ReadKey();
            Enemigo enemigoNivel2 = SeleccionarEnemigo(1, grupoDeEnemigos);
            //Console.WriteLine("\nCALCULO EL DAÑO QUE PROVOCARA EL Enemigo");
            //danioProvocado = enemigoNivel1.danioProvocado();
            //Console.WriteLine("El daño es de: " + danioProvocado);

            Console.WriteLine("\n\n                   DATOS DE TU ENEMIGA:");
            enemigoNivel2.MostrarPersonaje();
            Console.Write("\n\n\n                   Preciona una tecla cuando estes lista para destrozarla:\n\n");
            
            graficosPelea();
            Console.ReadKey();
            ResultadoPelea = Pelea(player, enemigoNivel2);

            if (ResultadoPelea)
            {
                Console.Write(@"



            **************************************************************************************
            *                                                                                    *
            *           ███████████████████████████████████████████████████████████████          *
            *           █▄─▄▄─█▄─▄▄─█▄─▄███▄─▄█─▄▄▄─█▄─▄█▄─▄▄▀██▀▄─██▄─▄▄▀█▄─▄▄─█─▄▄▄▄█          *
            *           ██─▄████─▄█▀██─██▀██─██─███▀██─███─██─██─▀─███─██─██─▄█▀█▄▄▄▄─█          *
            *           ▀▄▄▄▀▀▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▀▄▄▄▄▄▀▄▄▄▀▄▄▄▄▀▀▄▄▀▄▄▀▄▄▄▄▀▀▄▄▄▄▄▀▄▄▄▄▄▀          *
            *                                                                                    *
            *                             Player: {0}                                            *
            *                               VENCISTE EN TU SEGUNDA PELEA                         *
            *                         Cada vez estas mas cerca de tu titulo!!                    *
            *                                                                                    *
            **************************************************************************************
            ",player.Nombre);
                //player.SetSalud(1000);
                //Console.WriteLine("\nFelisidades sobrevisite a la materia: Salud Restaurada" + player.Salud);
                // realizar las actualizaciones / bonificaciones
                Console.WriteLine("\n\n\n              > Aplicando Bonos Por vencedor");
                DarBonos(player);


                
                Console.WriteLine("\n\n\n\n             PREPARANDO TU SIGUIENTE ENEMIGA... \n             Pulsa una tecla cuando estes listo para conocerla");
                Console.ReadKey();

                Enemigo enemigoNivel3 = SeleccionarEnemigo(2, grupoDeEnemigos);
                //Console.WriteLine("\nCALCULO EL DAÑO QUE PROVOCARA EL Enemigo");
                //danioProvocado = enemigoNivel3.danioProvocado();
                //Console.WriteLine("El daño es de: " + danioProvocado);
                //enemigoNivel3.MostrarPersonaje();
                Console.WriteLine("\n\n                   DATOS DE TU ENEMIGA:");
                enemigoNivel3.MostrarPersonaje();
                Console.Write("\n\n\n                   Preciona una tecla cuando estes lista para destrozarla:\n\n");
                
                graficosPelea();
                Console.ReadKey();
                ResultadoPelea= Pelea(player, enemigoNivel3);

                if (ResultadoPelea)
                {
                    //player.SetSalud(1000);
                    //Console.WriteLine("\nFelisidades sobrevisite a la materia: Salud Restaurada" + player.Salud);
                    // realizar las actualizaciones / bonificaciones
                    Console.WriteLine("\n\n\n              > Aplicando Bonos Por vencedor");
                    DarBonos(player);

                    //Console.WriteLine("\nPREPARANDO EL PROYECTO FINAL ");
                    grupoDeEnemigos[3][0].Nombre = "TESIS";
                    grupoDeEnemigos[3][0].Apodo = "Tesis";
                    ResultadoPelea = Pelea(player, grupoDeEnemigos[3][0]);

                    Console.Write("\n\n\n              Antes de Seguir Te voy a contar un chiste");
                    await MostrarChisteDeChuckNorris();
                    Console.Write(@"



                    **************************************************************************************
                    *                                                                                    *
                    *                                                                                    *
                    *                 Muy bien {0} hasta ahora todo fue bastante Tranquilo               *
                    *                Pero ahora te enfrentaras al miedo de todo Estudiante               *
                    *                         ¿Podras conseguir la gloria?                               *
                    *                                                                                    *
                    *                                                                                    *
                    *                   ███████████████████████████████████████████                      *
                    *                   █▄─▄████▀▄─████─▄─▄─█▄─▄▄─█─▄▄▄▄█▄─▄█─▄▄▄▄█                      *
                    *                   ██─██▀██─▀─██████─████─▄█▀█▄▄▄▄─██─██▄▄▄▄─█                      *
                    *                   ▀▄▄▄▄▄▀▄▄▀▄▄▀▀▀▀▄▄▄▀▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▀▄▄▄▄▄▀                      *
                    *                                                                                    *
                    *                                                                                    *
                    *                                                                                    *
                    **************************************************************************************
                    ",player.Nombre);
                    if (ResultadoPelea)
                    {
                        Console.Write(@"

















                        **************************************************************************************
                        *                                                                                    *
                        *                                                                                    *
                        *                                                                                    *
                        *                                                                                    *
                        *                   ███████████████████████████████████████████                      *
                        *                   █▄─▄████▀▄─████─▄─▄─█▄─▄▄─█─▄▄▄▄█▄─▄█─▄▄▄▄█                      *
                        *                   *******************************************                      *
                        *                   ▀▄▄▄▄▄▀▄▄▀▄▄▀▀▀▀▄▄▄▀▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▀▄▄▄▄▄▀                      *
                        *                                                                                    *
                        *                           ROMPISTE LA TESISSSSSS                                   *
                        *                                                                                    *
                        *                                                                                    *
                        **************************************************************************************
                        ",player.Nombre);


                        Thread.Sleep(3000);

                        Console.Write(@"




                        ***********************************************************************************************************************************
                        *                                                                                                                                 *
                        *                                                                                                                                 *
                        *                                                                                                                                 *
                        *    ████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████     *
                        *    █░░░░░░░░░░░░░░█░░░░░░████████████░░░░░░░░░░░░░░█░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░██░░░░░░█░░░░░░█████████░░░░░░░░░░░░░░█     *
                        *    █░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀░░████████████░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀░░██░░▄▀░░█░░▄▀░░█████████░░▄▀▄▀▄▀▄▀▄▀░░█     *
                        *    █░░▄▀░░░░░░░░░░█░░▄▀░░████████████░░░░░░▄▀░░░░░░█░░░░▄▀░░░░█░░░░░░▄▀░░░░░░█░░▄▀░░██░░▄▀░░█░░▄▀░░█████████░░▄▀░░░░░░▄▀░░█     * 
                        *    █░░▄▀░░█████████░░▄▀░░████████████████░░▄▀░░███████░░▄▀░░███████░░▄▀░░█████░░▄▀░░██░░▄▀░░█░░▄▀░░█████████░░▄▀░░██░░▄▀░░█     *
                        *    █░░▄▀░░░░░░░░░░█░░▄▀░░████████████████░░▄▀░░███████░░▄▀░░███████░░▄▀░░█████░░▄▀░░██░░▄▀░░█░░▄▀░░█████████░░▄▀░░██░░▄▀░░█     *
                        *    █░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀░░████████████████░░▄▀░░███████░░▄▀░░███████░░▄▀░░█████░░▄▀░░██░░▄▀░░█░░▄▀░░█████████░░▄▀░░██░░▄▀░░█     *
                        *    █░░▄▀░░░░░░░░░░█░░▄▀░░████████████████░░▄▀░░███████░░▄▀░░███████░░▄▀░░█████░░▄▀░░██░░▄▀░░█░░▄▀░░█████████░░▄▀░░██░░▄▀░░█     *
                        *    █░░▄▀░░█████████░░▄▀░░████████████████░░▄▀░░███████░░▄▀░░███████░░▄▀░░█████░░▄▀░░██░░▄▀░░█░░▄▀░░█████████░░▄▀░░██░░▄▀░░█     *
                        *    █░░▄▀░░░░░░░░░░█░░▄▀░░░░░░░░░░████████░░▄▀░░█████░░░░▄▀░░░░█████░░▄▀░░█████░░▄▀░░░░░░▄▀░░█░░▄▀░░░░░░░░░░█░░▄▀░░░░░░▄▀░░█     *
                        *    █░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░████████░░▄▀░░█████░░▄▀▄▀▄▀░░█████░░▄▀░░█████░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█░░▄▀▄▀▄▀▄▀▄▀░░█     *
                        *    █░░░░░░░░░░░░░░█░░░░░░░░░░░░░░████████░░░░░░█████░░░░░░░░░░█████░░░░░░█████░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█░░░░░░░░░░░░░░█     *
                        *    ████████████████████████████████████████████████████████████████████████████████████████████████████████████████████████     *                       *
                        *                                                                                                                                 *
                        *                                                                                                                                 *
                        *                      Se entrega este Titulo al sr/a  {0} en virtud de reconocimiento al esfuerzo y                                                                                                           * 
                        *                       dedicación demostrado al superar cada materia a lo largo de esta carrera.                                                                                                          *
                        *                                                                                                                                 *
                        ***********************************************************************************************************************************
                        ",player.Nombre);
                    } else {
                        graficoBatallaPerdida();
                        await MostrarChisteDeChuckNorris();
                    }
                } else {
                    graficoBatallaPerdida();
                    await MostrarChisteDeChuckNorris();
                }

            } else {
                /* Console.WriteLine("OBTUVISTE UN L");
                Console.WriteLine("Mejor suerte a la proxima");
                Console.WriteLine("Pelea2"); */
                graficoBatallaPerdida();
                await MostrarChisteDeChuckNorris();
            }

        } else {
            /* Console.WriteLine("OBTUVISTE UN L");
            Console.WriteLine("Mejor suerte a la proxima");
            Console.WriteLine("Pelea1"); */
            graficoBatallaPerdida();
            await MostrarChisteDeChuckNorris();
            
        }
    }

    static Personaje CrearPersonajePlayer()
    {
        Personaje nuevoPersonaje = new Personaje();

        Console.Write("     - Ingrese el nombre del personaje: ");
        nuevoPersonaje.Nombre = Console.ReadLine();

        Console.Write("                 - Ingrese el apodo del personaje: ");
        nuevoPersonaje.Apodo = Console.ReadLine();

        Console.Write("                 - Ingrese la carrera del personaje: ");
        nuevoPersonaje.Carrera = Console.ReadLine();

        Console.Write("                 - Ingrese la fecha de nacimiento del personaje (dd/MM/yyyy): ");
        string fechaIngresada = Console.ReadLine();
        if (DateTime.TryParse(fechaIngresada, out DateTime fechaNacimiento))
        {
            //Console.WriteLine("Fecha de Nacimiento: " + fechaNacimiento.ToShortDateString());
            nuevoPersonaje.FechaNacimiento = fechaNacimiento;
        }
        /* nuevoPersonaje.FechaNacimiento = DateTime.Parse(Console.ReadLine());*/
        Console.Write("\n                 Perfecto! Nosotros nos encargaremos de terminar de crear tu Personaje:\n");
        Console.Write("                 Solo danos unos segundos...");
        Thread.Sleep(5000); // para que espere...
        Console.Write("\n                 La creacion se concreto con Exito! Presione una tecla para continuar");
        Console.ReadKey();
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
        if (manejoDeDatos.Existe("Enemigos.json"))
        {
            /* Console.WriteLine("\nMostrado de los Datos de los Enemigos\n");
            Console.WriteLine("**************************************\n");*/
            List<Enemigo>[] grupoDeEnemigos = manejoDeDatos.LeerEnemigos("Enemigos.json");
            /*for (int i = 0; i < grupoDeEnemigos.Length; i++)
            {
                foreach (var enemigo in grupoDeEnemigos[i])
                {
                    enemigo.MostrarPersonaje();
                    Console.WriteLine("\n");
                }
            } */

            return grupoDeEnemigos;
        } else {
            // Crear un arreglo de listas de personajes
            List<Enemigo>[] grupoDeEnemigos = new List<Enemigo>[4];
            grupoDeEnemigos[0] = CargarListasDePersonajes(3, 1, 1, 10);
            grupoDeEnemigos[1] = CargarListasDePersonajes(3, 2, 2, 10);
            grupoDeEnemigos[2] = CargarListasDePersonajes(3, 3, 3, 10);
            grupoDeEnemigos[3] = CargarListasDePersonajes(1, 4, 4, 10);

            //Muestro los enemigos
            /* Console.WriteLine("\nMostrado de los Datos de los Enemigos Creados\n");
            Console.WriteLine("**************************************\n");
            
            for (int i = 0; i < grupoDeEnemigos.Length; i++)
            {
                foreach (var enemigo in grupoDeEnemigos[i])
                {
                    enemigo.MostrarPersonaje();
                    Console.WriteLine("\n");
                }
            } */

            //Guardo a los enemigos Creados en el JSON correspondiente
            manejoDeDatos.GuardarEnemigos("Enemigos.json", grupoDeEnemigos);
            return grupoDeEnemigos;
        }
    }

    static Personaje VerificarExistenciaPlayer()
    {
        PersonajesJson manejoDeDatos = new PersonajesJson();
        if (manejoDeDatos.Existe("Player.json"))
        {
            //Console.WriteLine("\nEl archivo si existe de player si existe");
            Personaje playerr = manejoDeDatos.LeerPlayer("Player.json");
            /* Console.WriteLine("Mostrado de Player:\n");
            playerr.MostrarPersonaje(); */
            return playerr;
        } else {
            //Console.WriteLine("Cargado de los datos del personaje: ");
            Personaje playerr = CrearPersonajePlayer();
            /* Console.WriteLine("Mostrado de Player:");
            playerr.MostrarPersonaje(); */

            //Guardado de los datos del player
            manejoDeDatos.GuardarPlayer("Player.json", playerr);
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
            /* Console.WriteLine("SOBREVISTE A LA MATERIA"); */
            player.SetSalud(0);
            return true;
        } else {
            /* Console.WriteLine("GANADORRRR: La mateira: \n");
            enemigo.MostrarPersonaje(); */
            enemigo.SetSalud(0);
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
        //Console.WriteLine("\nBONOS APLICADOS POR GANADOR");
        //Player.MostrarPersonaje();
    }

    static void graficosPelea()
    {
        Console.Write(@"
                    A Pelear Entonces!

                     ( •_•)     (•_• )
                     (ง )ง      ୧( ୧)
                     / \         / \


        ");
        Thread.Sleep(3000);
        Console.Write("                ufff fue una pelea dura...\n                       Pero TENEMOS 1 GANADOR:");

    }

    static async void graficoBatallaPerdida()
    {
        Console.Write(@"
            
            ************************************************************************************************** 
            *                                                                                                *
            *                                                                                                *
            *    ████████████████████████████████████████████████████████████████████████████████████████    *
            *    █─▄▄─█▄─▄─▀█─▄─▄─█▄─██─▄█▄─█─▄█▄─▄█─▄▄▄▄█─▄─▄─█▄─▄▄─███▄─██─▄█▄─▀█▄─▄█████░█░█▄─▄███░█░█    *
            *    █─██─██─▄─▀███─████─██─███▄▀▄███─██▄▄▄▄─███─████─▄█▀████─██─███─█▄▀─██████▄█▄██─██▀█▄█▄█    *
            *     ▄▄▄▄▀▄▄▄▄▀▀▀▄▄▄▀▀▀▄▄▄▄▀▀▀▀▄▀▀▀▄▄▄▀▄▄▄▄▄▀▀▄▄▄▀▀▄▄▄▄▄▀▀▀▀▄▄▄▄▀▀▄▄▄▀▀▄▄▀▀▀▀▀▀▀▀▀▄▄▄▄▄▀▀▀▀▀    *   *                                                                                                *
            *                                                                                                *
            *                                                                                                *
            *                         Se ve que estudiaste pero no alcanzo...                                *
            *                                   PERDISTE                                                     *
            *                                                                                                *
            **************************************************************************************************
            
            ");
            
    }

    static async Task MostrarChisteDeChuckNorris()
        {
            // URL de la API de Chuck Norris Jokes
            string apiUrl = "https://api.chucknorris.io/jokes/random";

            // Crea una instancia de HttpClient para realizar la solicitud HTTP
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await httpClient.GetAsync(apiUrl); //para que se dispare la solicitud http
                    response.EnsureSuccessStatusCode();
                    JokeResponse jokeResponse = await response.Content.ReadFromJsonAsync<JokeResponse>(); //e verifica si la respuesta tiene un código de estado de éxito (por ejemplo, 200)

                    // Imprime el chiste en la consola si todo salio bien
                    Console.WriteLine($" \n\n\n          Chiste: {jokeResponse.Value}");
                }
                catch (HttpRequestException ex) //sino se manejan ls excepciones
                {
                    Console.WriteLine($"Error al realizar la solicitud HTTP: {ex.Message}");
                }
            }
        }
   
}


