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
        public int Velocidad { get; private set; }
        public int Destreza { get; private set; }
        public int Nivel { get; private set; }
        public int Memoria { get; private set; }
        public int Talento { get; private set; }
        public int Salud { get; private set; }

        // Constructor de la clase Personaje
        public Enemigo(int minRamdom, int maxRamdom)
        {
            // Generar el tipo aleatoriamente
            Random random = new Random();
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
            Nivel = 0;

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
            Console.WriteLine("Tipo: {0}", Tipo);
            Console.WriteLine("Nombre: {0}", Nombre);
            Console.WriteLine("Apodo: {0}", Apodo);
            Console.WriteLine("Carrera: {0}", Carrera);
            Console.WriteLine("Velocidad: {0}", Velocidad);
            Console.WriteLine("Destreza: {0}", Destreza);
            Console.WriteLine("Nivel: {0}", Nivel);
            Console.WriteLine("Memoria: {0}", Memoria);
            Console.WriteLine("Talento: {0}", Talento);
            Console.WriteLine("Salud: {0}", Salud);
        }
    }
}