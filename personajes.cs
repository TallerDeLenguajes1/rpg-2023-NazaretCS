namespace EspacioPersonajes {
    public class Personaje
    {
        public static string[] tiposPosibles = { "Amsioso", "Aplicado", "Bago", "Suertudo", "Obligado", "Procastinador" };
        public static string[] materias = {"MÉTODOS NUMÉRICOS I", "TALLER DE LENGUAJES I", "TALLER DE LENGUAJES II", "MÉTODOS NUMÉRICOS II", "ALGORITMOS Y ESTRUCTURAS DE DATOS I", "ARQUITECTURA Y ORGANIZACIÓN DE COMPUTADORAS", "PROBABILIDAD Y ESTADÍSTICA"};
        public static string[] apodoMaterias = {"MNI", "TLI", "TLII", "MNII", "AED", "ARQ", "PyE"};
        public static string[] carreras = {"PU", "ING INF", "LIC INF", "ING COMP"};
        // Propiedades del personaje
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Apodo { get; set; }
        public string Carrera { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Edad => (int)((DateTime.Now - FechaNacimiento).TotalDays / 365.25); // calculo de la edad basado en la fecha de nacimiento
        public int Velocidad { get; private set; }
        public int Destreza { get; private set; }
        public int Nivel { get; private set; }
        public int Apuntes { get; private set; }
        public int Memoria { get; private set; }
        public int Talento { get; private set; }
        public int Salud { get; private set; }

        // Constructor de la clase Personaje
        public Personaje(int minRamdom, int maxRamdom)
        {
            // Generar el tipo aleatoriamente
            Random random = new Random();
            Tipo = tiposPosibles[random.Next(tiposPosibles.Length)];

            // Generar atributos aleatorios entre 1 y 10
            Velocidad = random.Next(minRamdom, maxRamdom);
            Destreza = random.Next(minRamdom, maxRamdom);
            Nivel = random.Next(minRamdom, maxRamdom);
            Apuntes = random.Next(minRamdom, maxRamdom);
            Memoria = random.Next(minRamdom, maxRamdom);
            Talento = random.Next(minRamdom, maxRamdom);
            Salud = 100; // Multiplicamos por 10 para obtener un valor entre 10 y 100


            Nombre = materias[random.Next(materias.Length)];
            Apodo = apodoMaterias[random.Next(apodoMaterias.Length)];
            Carrera = carreras[random.Next(carreras.Length)];
            FechaNacimiento = DateTime.MinValue;
        }

        // Método para mostrar los datos del personaje
        public void MostrarPersonaje()
        {
            Console.WriteLine("Tipo: {0}", Tipo);
            Console.WriteLine("Nombre: {0}", Nombre);
            Console.WriteLine("Apodo: {0}", Apodo);
            Console.WriteLine("Carrera: {0}", Carrera);
            Console.WriteLine("Fecha de Nacimiento: {0}", FechaNacimiento.ToShortDateString());
            Console.WriteLine("Edad: {0}", Edad);
            Console.WriteLine("Velocidad: {0}", Velocidad);
            Console.WriteLine("Destreza: {0}", Destreza);
            Console.WriteLine("Nivel: {0}", Nivel);
            Console.WriteLine("Apunte: {0}", Apuntes);
            Console.WriteLine("Memoria: {0}", Memoria);
            Console.WriteLine("Talento: {0}", Talento);
            Console.WriteLine("Salud: {0}", Salud);
        }
    }

}