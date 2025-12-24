using ProjetoLivros;

//Instâncias
Autor autor = new Autor("Kamaitachi");

LivroFisico livro1 = new LivroFisico("Histórias Extraordinárias", autor, 447, true);
LivroDigital livro2 = new LivroDigital("Mitologia Nórdica", autor, 286, 127);

Leitor leitor1 = new Leitor("Arthur", 22);

Box box = new Box("Contos do Desconhecido");

Capitulo capitulo = new Capitulo(1, "Ligeia", 30);
Capitulo capitulo1 = new Capitulo(2, "Astaroth", 50);
Capitulo capitulo2 = new Capitulo(2, "Vagro", 20);

//Setando valores
livro1.Lido = false;
livro2.Lido = true;

//Chamada de métodos
box.AdicionaLivro(livro2);
box.AdicionaLivro(livro1);

autor.AddBox(box);

//desafio
capitulo.AdicionarTopico("Minha bela esposa");
capitulo.AdicionarTopico("Poder imensuravel");
capitulo.AdicionarTopico("Putridão");

livro1.AddCapitulo(capitulo);
livro1.AddCapitulo(capitulo1);
livro1.AddCapitulo(capitulo2);

//livro1.ExibirDetalhes();

