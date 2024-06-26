namespace ExercEventos.Domain
{
    abstract class Evento
    {
        public string Nome { get; set; }
        public DateTime Data { get; set; }
        public string Local { get; set; }
        public int CapacidadeMaxima { get; set; }
        public GradeEvento GradeEvento { get; set; }
        public void IniciarEvento() { }
        public void PausarEvento() { }
        public void ConcluirEvento() { }
        public void CancelarEvento() { }

    }
}
