namespace ExercEventos.Domain
{
    internal class Conferencia : Evento
    {
        public List<Atividade> Atividades { get; set; }
        public void IniciarConferencia() { }
    }
}
