namespace FabricaDePersonajes {
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
        public double Animos { get; private set; }
        public int Nivel { get; private set; }
        public double Apuntes { get; private set; }
        public int Memoria { get; private set; }
        public int Talento { get; private set; }
        public double Salud { get; private set; }

        // Constructor de la clase Personaje
        public Personaje()
        {
            // Generar el tipo aleatoriamente
            Random random = new Random();
            Tipo = tiposPosibles[random.Next(tiposPosibles.Length)];
            Nombre = materias[random.Next(materias.Length)];
            Apodo = apodoMaterias[random.Next(apodoMaterias.Length)];
            Carrera = carreras[random.Next(carreras.Length)];
            FechaNacimiento = DateTime.MinValue;
            Nivel = 1;

            // Generar atributos aleatorios entre 1 y 10
            Velocidad = random.Next(1, 10);
            Animos = random.Next(1, 10);
            Apuntes = random.Next(1, 10);
            Memoria = random.Next(1, 10);
            Talento = random.Next(1, 10);
            Salud = 1000;   //Uno ingresa lleno de vida a la facu
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
            Console.WriteLine("                 Fecha de Nacimiento: {0}", FechaNacimiento.ToShortDateString());
            Thread.Sleep(400);
            Console.WriteLine("                 Edad: {0}", Edad);
            Thread.Sleep(400);
            Console.WriteLine("                 Velocidad: {0}", Velocidad);
            Thread.Sleep(400);
            Console.WriteLine("                 Animos: {0}", Animos);
            Thread.Sleep(400);
            Console.WriteLine("                 Nivel: {0}", Nivel);
            Thread.Sleep(400);
            Console.WriteLine("                 Apunte: {0}", Apuntes);
            Thread.Sleep(400);
            Console.WriteLine("                 Memoria: {0}", Memoria);
            Thread.Sleep(400);
            Console.WriteLine("                 Talento: {0}", Talento);
            Thread.Sleep(400);
            Console.WriteLine("                 Salud: {0}", Salud);
            
        }

        public int efectividadAtaque()
        {
            Random rand = new Random();
            int efectividad = rand.Next(0,101);
            return efectividad;
        }

        public double ataque()
        {
            return(Animos * Memoria * Nivel * Talento);
        }

        public double defenza()
        {
            return(Apuntes * Velocidad);
        }

        public int constanteAjuste()
        {
            return 300;
        }

        public double danioProvocado()
        {
            return ((((ataque()) * (efectividadAtaque())) - defenza()) / constanteAjuste());
        }

        public double GetSalud() => this.Salud;
        public double GetApuntes() => this.Apuntes;
        public double GetAnimos() => this.Animos;
        public double SetSalud(double nuevaSalud) => this.Salud = Math.Round(nuevaSalud,3);
        public double SetApuntes(double nuevosApuntes) => this.Apuntes = nuevosApuntes;
        public double SetAnimos(double nuevosAnimos) => this.Animos = nuevosAnimos;

        public void actualizaSalud(double danioRecibido)
        {
            double saludActualizada = this.GetSalud();
            saludActualizada -= danioRecibido;
            this.SetSalud(saludActualizada);
        }

/*           

        public double valorAtaque() => Math.Round(this.PD * this.efectividaDisparo(),3);
        public double poderDefensa() => Math.Round(this.armadura * this.velocidad,3);
        //Get de salud
        public double GetSalud() => this.Salud;

        //Metodos Setter
        public double SetSalud(double nuevaSalud) => this.Salud = Math.Round(nuevaSalud,3); */
    }

}