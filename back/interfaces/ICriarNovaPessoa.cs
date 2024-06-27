using back.Entidades;
using Microsoft.AspNetCore.Mvc;

namespace back.interfaces
{
    public interface ICriarNovaPessoa
    {
        IActionResult criarNovaPessoa(NomePessoa NomePessoa);
    }
}