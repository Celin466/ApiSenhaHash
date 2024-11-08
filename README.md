Está é uma simples API utilizada para criptografia de senhas utilizando hash, funciona de seguinte maneira
https://localhost:7273/api/Criptografar
body = {
    "senha" : "teste"
}
Essa rota ira retornar a senha criptografada, para realizar uma validação de usuario, basta usar a rota para descriptografar

https://localhost:7273/api/Criptografar/Descriptografar
body = {
    "SenhaDoUsuario" : "teste",
    "SenhaCriptografada": "$2a$11$fEJsLmKs9WbGo0WQz0txgelxCAHunns1wJykAQKFC9BCOJGOUgB5e"
}
Essa rota vai retornar verdadeiro ou falso dependendo se a senha que usuário inseriu for igual ao código hash.
