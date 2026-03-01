console.log("Trabalhado com Variaveis");

const nome = "Luan Silva", altura = 173, peso = 56, idade = 23;

console.log("Nome: " + nome + ", Idade: " + idade + ", Altura: " + altura + ", Peso: " + peso);

console.log(`Teste de lista de Livros: `);

const listaLivros = new Array(
    "Armagedom 2419 A.D.",
    "Histórias primordiais",
    "A canção de Erich Zann",
    "Deuses exteriores"
);

console.log(listaLivros);

listaLivros.push("Os iluminados")

if(listaLivros.find(l => l == "Os iluminados"))
{
    console.log("Encontrado");
    console.log(listaLivros);
    listaLivros.splice(1,2);
}
else
{
    console.log("Não encontrado");
}

console.log(listaLivros[2]);