namespace ProjetoLivros.Modelos
{
    public class Avaliacao
    {
        public Avaliacao(int nota, string comentario)
        {
            Nota = nota;
            Comentario = comentario;
        }

        public Avaliacao() { }

        public int Id { get; set; }
        public int Nota { get; set; }
        public string Comentario { get; set; }
    }
}
