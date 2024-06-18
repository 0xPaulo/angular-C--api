using PrimeiraApi.Entidades;

namespace PrimeiraApi.Routes
{



    public static class PessoaRotas
    {

        public static List<Pessoa> Pessoas = new(){
        new (Guid.NewGuid(), "Romario"),
        new (Guid.NewGuid(), "Betao"),
        new (Guid.NewGuid(), "Tursvaldo")
    };
        public static void MapPessoaRotas(this WebApplication app)
        {
            app.MapGet("/pessoas", () => Pessoas);
            app.MapGet("/pessoas/{nome}", (string nome) => Pessoas.Find(x => x.Nome == nome));
            app.MapPost("/pessoas", (Pessoa pessoa) =>
            {
                if (pessoa.Nome != "Serjao")
                {
                    return Results.BadRequest(new { mensagem = "nao é o serjao" });
                }
                Pessoas.Add(pessoa);
                return Results.Ok(pessoa);
            });
            app.MapPut("/pessoas/{id}", (Guid id, Pessoa pessoa) =>
            {
                var achado = Pessoas.Find(x => x.Id == id);
                if (achado == null)
                {
                    return Results.NotFound();
                }
                achado.Nome = pessoa.Nome;
                return Results.Ok();
            });
            app.MapDelete("/pessoas/{nome}", (string nome) =>
            {
                var achado = Pessoas.Find(x => x.Nome == nome);
                if (achado == null)
                {
                    return Results.NotFound();
                }
                Pessoas.Remove(achado);
                return Results.Ok();

            });
        }
    }
}