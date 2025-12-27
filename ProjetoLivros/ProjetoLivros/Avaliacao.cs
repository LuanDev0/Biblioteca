namespace ProjetoLivros
{
    public class Avaliacao
    {
        public Avaliacao(int nota, string comentario)
        {
            Nota = nota;
            Comentario = comentario;
        }

        public int Nota { get; set; }
        public string Comentario { get; set; }
    }
}
