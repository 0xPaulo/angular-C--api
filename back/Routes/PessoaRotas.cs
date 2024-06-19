using back.Entidades;
using PrimeiraApi.Entidades;

namespace PrimeiraApi.Routes
{



    public static class PessoaRotas
    {

        public static List<Pessoa> Pessoas = new(){
        new (Guid.NewGuid(), "Joao"),
        new (Guid.NewGuid(), "Maria"),
        new (Guid.NewGuid(), "Jose")
    };
        public static void MapPessoaRotas(this WebApplication app)
        {
            app.MapGet("/pessoas", () => Pessoas);
            app.MapGet("/pessoas/{id}", (Guid id) => Pessoas.Find(x => x.Id == id));
            app.MapPost("/pessoas", (NomePessoa NomePessoa) =>
            {
                if (NomePessoa == null) return Results.BadRequest(new { mensagem = "Pessoa Invalida" });
                Pessoa novaPessoa = new Pessoa(Id: Guid.NewGuid(), Nome: "")
                {
                    Nome = NomePessoa.Nome
                };
                Pessoas.Add(novaPessoa);
                return Results.Ok(novaPessoa);
            });
            app.MapPut("/pessoas/{id}", (Guid id, Pessoa novoNome) =>
            {
                var pessoaEncontrada = Pessoas.Find(x => x.Id == id);
                if (pessoaEncontrada == null) return Results.NotFound(new { mensagem = "Pessoa nao encontada" });
                pessoaEncontrada.Nome = novoNome.Nome;
                return Results.Ok(pessoaEncontrada);
            });
            app.MapDelete("/pessoas/{id}", (Guid id) =>
            {
                var pessoaEncontrada = Pessoas.Find(x => x.Id == id);
                if (pessoaEncontrada == null) return Results.NotFound(new { mensagem = "Essa pessoa nao existe" });
                Pessoas.Remove(pessoaEncontrada);
                return Results.Ok(new { mensagem = $"A pessoa {pessoaEncontrada.Nome} foi apagada." });
            });
        }
    }
}