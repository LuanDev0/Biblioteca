import { Biblioteca } from "./Biblioteca.js";
import { Usuario } from "./Usuario.js";

const biblioteca = new Biblioteca("Aberta");
const usuario = new Usuario();

usuario.Nome = "Luan Silva";
usuario.Idade = 23;
usuario.Rg = "56.656.820.2";

console.log("\nNome: " + usuario.Nome + ", Idade: " + usuario.Idade + ", Rg: " + usuario.Rg);

console.log(`Estado da Biblioteca: ${biblioteca.Aberta}\n\n Lista de Livros: `);

console.log(biblioteca.Livros);

biblioteca.Livros.push("Os iluminados")

if (biblioteca.Livros.find(l => l == "Os iluminados")) {
    console.log("Encontrado");
    console.log(biblioteca.Livros);
    biblioteca.Livros.splice(1, 2);
}
else {
    console.log("Não encontrado");
}

console.log(biblioteca.Livros[2]);

