using Criptografia.web.Models;
using Criptografia.web.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Criptografia.web.Api;


public class CriptografarController : BaseApiController
{

    [HttpPost]
    public IActionResult CriptografarSenha(SenhaRequest request)
    {
        if (request == null) return Error("Coloque a senha!");

        var senhaCriptografada = PasswordHash.HashPassword(request.Senha);


        return Success(new
        {
            SenhaCriptografada = senhaCriptografada
        });
    }

    [HttpPost("Descriptografar")]
    public IActionResult DescriptografarSenha(DescriptografarRequest request)
    {
        if (request == null) return Error("Insira os dados!");

        var resposta = BCrypt.Net.BCrypt.Verify(request.SenhaDoUsuario, request.SenhaCriptografada);

        return Success(new
        {
            senhasCoincidem = resposta
        });
    }
}
