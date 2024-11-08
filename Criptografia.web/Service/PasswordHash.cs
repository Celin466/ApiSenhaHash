namespace Criptografia.web.Service;

public static class PasswordHash
{
    public static string HashPassword(string password)
    {
        return BCrypt.Net.BCrypt.HashPassword(password);
    }

    public static bool VerifyPassword(string passwordHash, string passwordRequest)
    {
        var resposta = BCrypt.Net.BCrypt.Verify(passwordRequest, passwordHash);
        return resposta;
    }
}
