
namespace ExercEventos.Domain
{
    internal class Atividade
    {
        public List<Palestrante> Palestrante { get; set; }
        public string Titulo { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public string Descricao {  get; set; }
        public string Local {  get; set; }

    }
}
