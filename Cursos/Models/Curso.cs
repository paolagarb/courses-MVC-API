namespace Cursos.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Plataforma Plataforma { get; set; }
        public int PlataformaId { get; set; }
        public bool TemCertificado { get; set; }
        public bool CertificadoGratuito { get; set; }

        public Curso()
        {

        }
    }
}
