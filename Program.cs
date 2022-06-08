// Utilize a mensagem a seguir como base do retorno esperado:
// Olá João, você nasceu em XXXX.

string nomeDoUsuario;
int idadeDoUsuario;
int anoAtual = 2022;
int anoNascimento;

Console.WriteLine("Qual seu nome? ");
nomeDoUsuario = Console.ReadLine();
Console.WriteLine("Qual sua idade? ");
idadeDoUsuario = int.Parse(Console.ReadLine());

anoNascimento = anoAtual - idadeDoUsuario;


Console.Write($"Olá {nomeDoUsuario}, você nasceu em {anoNascimento}!");