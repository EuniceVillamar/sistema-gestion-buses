namespace Modelo
{
    public class Programadores
    {
        public int idIntegrante { get; set; }

        public string nombreSistema { get; set; }
        public string nombreIntegrante { get; set; }
        public string correoIntegrante { get; set; }
        public string celularIntegrante { get; set; }
        public string fotoLink { get; set; }

        public Programadores(string nombreSistemas, string nombresIntegrantes, string correosIntegrantes,
            string celularesIntegrantes)
        {
            nombreSistema = nombreSistemas;
            nombreIntegrante = nombresIntegrantes;
            correoIntegrante = correosIntegrantes;
            celularIntegrante = celularesIntegrantes;
            fotoLink = "";
        }
    }
}