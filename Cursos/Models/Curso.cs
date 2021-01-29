namespace Cursos.Models
{
    public class Curso
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Plataforma Plataforma { get; set; }
        public int PlataformaId { get; set; }
        public Curso()
        {

        }
    }
}
