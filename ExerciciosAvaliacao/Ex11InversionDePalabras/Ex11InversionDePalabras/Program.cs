/*Exercício 11: Inversão de Palavras:
Dada uma lista de palavras, utilize LINQ para criar uma nova lista com as palavras invertidas.*/

List<string> palavras;

do
{
    Console.Clear();
    Console.WriteLine("\nExercicio 11 - Tutorial 15");

    palavras = [];

    do
    {
        palavras.Add(String("\nQual palavra deseja inserir?: "));
    } while (Deseja("Deseja inserir outra palavra à lista?"));

    palavras.Reverse();

    Console.WriteLine($"\nPalavras invertidas:\n\n\t {string.Join("\n\t", palavras)}");

} while (Deseja("Deseja inserir outra lista de palavras?"));

string String(string enunciado)
{
    string? texto;

    while (true)
    {
        Console.Write(enunciado);
        texto = Console.ReadLine();

        if (!string.IsNullOrEmpty(texto))
        {
            var confirmacionPalabra = texto.Trim().Split(' ');

            if (confirmacionPalabra.Length == 1)
                return texto.Trim();
        }

        Console.WriteLine("\n\tPalabra invalida!!!!!! Tente novamente");
    }
}

bool Deseja(string enunciado)
{
    string? texto;

    while (true)
    {
        Console.Write($"\n{enunciado} Sim/Não?: ");
        texto = Console.ReadLine();

        if (!string.IsNullOrEmpty(texto))
        {
            if (texto.ToLower() == "sim")
                return true;

            if (texto.ToLower() == "não" || texto.ToLower() == "nao")
                return false;
        }

        Console.WriteLine("\nOpção inválida!!!!! É SIM/NÃO!!!");
    }
}
