using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLivros
{
    class Capitulo
    {
        public Capitulo(int numeroCap, string titulo, int numeroPag)
        {
            NumeroCap = numeroCap;
            Titulo = titulo;
            NumeroPag = numeroPag;
        }

        List<string> topicos = new List<string>();

        //Propriedades
        public int NumeroCap { get; }
        public string Titulo { get; }
        public int NumeroPag { get; }
        public string resumo  => $"Título do capítulo {Titulo}, número de capítulos {NumeroCap}, " +
            $"quantidade de pagínas {NumeroPag} e tópicos abordados: {string.Join(", ", topicos)}" ;

        public void AdicionarTopico(string topico)
        {
            topicos.Add(topico);
        }

    }
}
