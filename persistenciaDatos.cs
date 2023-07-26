using System.Text.Json;
using System.IO;
using System.Text.Json.Serialization;

using FabricaDeEnemigos;
using FabricaDePersonajes;
namespace persistenciaDatos{
    public class PersonajesJson{

        //Serializado y Deserializado de los enemigos
        public void GuardarEnemigos(string nombreArchivo, List<Enemigo>[] grupoEnemigos)
        {
            //Serializado
            //Console.Write(InformePrograma.CantidadDeProductos);
            string json = JsonSerializer.Serialize(grupoEnemigos);
            string rutaCompleta = Path.Combine("ArchivosJSON", nombreArchivo);  //lo uso para que lo gurde dentro de la carpeta para asi tener mas estructrada la cuestio 
            //Console.WriteLine(json);              
            File.WriteAllText(rutaCompleta, json);
        }

        public List<Enemigo>[] LeerEnemigos(string archivoJSON)
        {
            //Console.WriteLine("DESSERIALIZADO:\n");
            string rutaCompleta = Path.Combine("ArchivosJSON", archivoJSON);
            string json2 = File.ReadAllText(rutaCompleta);
            //Console.WriteLine(json2);
            List<Enemigo>[] grupoEnemigos = JsonSerializer.Deserialize<List<Enemigo>[]>(json2);
            return grupoEnemigos;
        }


        //Serializado y Deserializado de Player
        public void GuardarPlayer(string nombreArchivo, Personaje player)
        {
            string json = JsonSerializer.Serialize(player);
            string rutaCompleta = Path.Combine("ArchivosJSON", nombreArchivo);
            File.WriteAllText(rutaCompleta, json);
        }

        public Personaje LeerPlayer(string archivoJSON)
        {
            string rutaCompleta = Path.Combine("ArchivosJSON", archivoJSON);
            string json2 = File.ReadAllText(rutaCompleta);
            Personaje player = JsonSerializer.Deserialize<Personaje>(json2);
            return player;
        }


        // Metodo para saber si el archivo pasado tiene o no tiene datos, al solo recivir el nombre sirve para cualquier archi
        public bool Existe(string nombreArchivo)
        {
            string rutaCompleta = Path.Combine("ArchivosJSON", nombreArchivo);

            // Verificar si el archivo existe
            if (File.Exists(rutaCompleta))
            {
                string contenido = File.ReadAllText(rutaCompleta);
                if (!string.IsNullOrWhiteSpace(contenido))
                {
                    return true;
                }
            }
            return false;
        }

    }
}