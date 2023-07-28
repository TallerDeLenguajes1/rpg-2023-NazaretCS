

namespace FabricaDeEnemigos {
    public class Enemigo
    {
        public static string[] tiposPosibles = { "Tediosa", "Teoricas", "Prácticas", "Perfecta", "Muy Buena", "Exelente" };
        public static string[] materias = {"MÉTODOS NUMÉRICOS I", "TALLER DE LENGUAJES I", "TALLER DE LENGUAJES II", "MÉTODOS NUMÉRICOS II", "ALGORITMOS Y ESTRUCTURAS DE DATOS I", "ARQUITECTURA Y ORGANIZACIÓN DE COMPUTADORAS", "PROBABILIDAD Y ESTADÍSTICA"};
        /* public static string[] apodoMaterias = {"MNI", "TLI", "TLII", "MNII", "AED", "ARQ", "PyE"}; */
        public static string[] carreras = {"PU", "ING INF", "LIC INF", "ING COMP"};
        // Propiedades del personaje
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Apodo { get; set; }
        public string Carrera { get; set; }
        public int Velocidad { get;  set; }
        public int Destreza { get;  set; }
        public int Nivel { get;  set; }
        public int Memoria { get;  set; }
        public int Talento { get;  set; }
        public double Salud { get;  set; }

        // Constructor de la clase Personaje
        
        /* public Enemigo(int minRamdom, int maxRamdom, int nivel)
        {
            // Generar el tipo aleatoriamente
            Random random = new Random();
            Tipo = tiposPosibles[random.Next(tiposPosibles.Length)];
            Nombre = materias[random.Next(materias.Length)];

            /* Apodo = apodoMaterias[random.Next(apodoMaterias.Length)]; */
            //En base a la materia escogida recojo el "apodo" de la materia...
            /* Apodo = Nombre switch
            {
                "MÉTODOS NUMÉRICOS I" => "MNI",
                "TALLER DE LENGUAJES I" => "TLI",
                "TALLER DE LENGUAJES II" => "TLII",
                "MÉTODOS NUMÉRICOS II" => "MTII",
                "ALGORITMOS Y ESTRUCTURAS DE DATOS I" => "AED",
                "ARQUITECTURA Y ORGANIZACIÓN DE COMPUTADORAS" => "ARQ",
                "PROBABILIDAD Y ESTADÍSTICA" => "PyE",
                _ => string.Empty // Opción por defecto si no coincide con ningún caso anterior
            };

            Carrera = carreras[random.Next(carreras.Length)];
            Nivel = nivel;

            // Generar atributos aleatorios entre 1 y 10
            Velocidad = random.Next(minRamdom, maxRamdom);
            Destreza = random.Next(minRamdom, maxRamdom);
            Memoria = random.Next(minRamdom, maxRamdom);
            Talento = random.Next(minRamdom, maxRamdom);
            Salud = 100; // Multiplicamos por 10 para obtener un valor entre 10 y 100
        } */
            


        //Constructor si parametros usado en la desearializacion del archivo, privado por las dudas
        public Enemigo()
        {
            // Generar el tipo aleatoriamente
            Random random = new Random();
            int nivel = 1;
            int minRamdom = 1;
            int maxRamdom = 1;
            Tipo = tiposPosibles[random.Next(tiposPosibles.Length)];
            Nombre = materias[random.Next(materias.Length)];

            /* Apodo = apodoMaterias[random.Next(apodoMaterias.Length)]; */
            //En base a la materia escogida recojo el "apodo" de la materia...
            Apodo = Nombre switch
            {
                "MÉTODOS NUMÉRICOS I" => "MNI",
                "TALLER DE LENGUAJES I" => "TLI",
                "TALLER DE LENGUAJES II" => "TLII",
                "MÉTODOS NUMÉRICOS II" => "MTII",
                "ALGORITMOS Y ESTRUCTURAS DE DATOS I" => "AED",
                "ARQUITECTURA Y ORGANIZACIÓN DE COMPUTADORAS" => "ARQ",
                "PROBABILIDAD Y ESTADÍSTICA" => "PyE",
                _ => string.Empty // Opción por defecto si no coincide con ningún caso anterior
            };

            Carrera = carreras[random.Next(carreras.Length)];
            Nivel = 1;

            // Generar atributos aleatorios entre 1 y 10
            Velocidad = random.Next(minRamdom, maxRamdom);
            Destreza = random.Next(minRamdom, maxRamdom);
            Memoria = random.Next(minRamdom, maxRamdom);
            Talento = random.Next(minRamdom, maxRamdom);
            Salud = 100; // Multiplicamos por 10 para obtener un valor entre 10 y 100
        }

        // Método para mostrar los datos del personaje
        public void MostrarPersonaje()
        {
            Console.WriteLine("                 Nombre: {0}", Nombre);
            Thread.Sleep(400);
            Console.WriteLine("                 Apodo: {0}", Apodo);
            Thread.Sleep(400);
            Console.WriteLine("                 Tipo: {0}", Tipo);
            Thread.Sleep(400);
            Console.WriteLine("                 Carrera: {0}", Carrera);
            Thread.Sleep(400);
            Console.WriteLine("                 Velocidad: {0}", Velocidad);
            Thread.Sleep(400);
            Console.WriteLine("                 Destreza: {0}", Destreza);
            Thread.Sleep(400);
            Console.WriteLine("                 Nivel: {0}", Nivel);
            Thread.Sleep(400);
            Console.WriteLine("                 Memoria: {0}", Memoria);
            Thread.Sleep(400);
            Console.WriteLine("                 Talento: {0}", Talento);
            Thread.Sleep(400);
            Console.WriteLine("                 Salud: {0}", Salud);
            Thread.Sleep(400);
        }

        public int efectividadAtaque()
        {
            Random rand = new Random();
            int efectividad = rand.Next(0,101);
            return efectividad;
        }

        public double ataque()
        {
            return(Destreza * Memoria * Nivel * Talento);
        }

        public double defenza()
        {
            return(Memoria * Velocidad);
        }

        public int constanteAjuste()
        {
            return 500;
        }

        public double danioProvocado()
        {
            return ((((ataque()) * (efectividadAtaque())) - defenza()) / constanteAjuste());
        }

        public double GetSalud() => this.Salud;
        public double SetSalud(double nuevaSalud) => this.Salud = Math.Round(nuevaSalud,3);

        public void actualizaSalud(double danioRecibido)
        {
            double saludActualizada = this.GetSalud();
            saludActualizada -= danioRecibido;
            this.SetSalud(saludActualizada);
        }
    }
}