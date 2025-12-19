using ProjetoLivros;

//Instâncias
Autor autor = new Autor("Kamaitachi");

Livro livro1 = new Livro("Histórias Extraordinárias", autor);
Livro livro2 = new Livro("Mitologia Nórdica", autor);

Leitor leitor1 = new Leitor("Arthur", 22);

Box box = new Box("Contos do Desconhecido");

Capitulo capitulo = new Capitulo(1, "Ligeia", 30);
Capitulo capitulo1 = new Capitulo(2, "Astaroth", 50);
Capitulo capitulo2 = new Capitulo(2, "Vagro", 20);


//Setando valores
livro1.Paginas = 447;
livro1.Lido = false;

livro2.Paginas = 286;
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

Console.WriteLine(capitulo.resumo);