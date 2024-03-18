/*Exercício 16: Pessoas Maiores de Idade:

Dada uma lista de objetos do tipo Pessoa (com propriedades Nome e Idade), utilize LINQ para encontrar e 
imprimir todas as pessoas que são maiores de idade.*/

using Ex16PessoasMaioresDeIdade.Entities;
using System.Globalization;

List<Pessoa> pessoas;

do
{
    Console.Clear();
    Console.WriteLine("\nExercicio 16 - Tutorial 15");

    pessoas = [];

    do
    {
        pessoas.Add(PessoaNova());
    } while (DesejaContinuar("Deseja inserir outra Pessoa?"));

    pessoas = [.. pessoas.Where(p => p.Idade > 18 - 1).OrderByDescending(p => p.Idade)];

    if (pessoas.Count == 0)
        Console.WriteLine("\nTodas as pessoas são menores de idade");

    else if (pessoas.Count == 1)
        Console.WriteLine($"\nSó há uma pessoa maior de idade que é {pessoas[0]}");

    else
        Console.WriteLine($"\nEstas são as pessoas maiores de idade:\n\n\t {string.Join("\n\t", pessoas)}");

} while (DesejaContinuar("Deseja inserir outras pessoas diferentes?"));

Pessoa PessoaNova()
{
    string nome = String("\nComo se chama a nova pessoa?: ");
    uint idade = UInt($"\nQuantos anos tem {nome}: ");

    return new Pessoa(nome, idade);
}

string String(string enunciado)
{
    string? texto;

    while (true)
    {
        Console.Write(enunciado);
        texto = Console.ReadLine();

        if (!string.IsNullOrEmpty(texto))
            return texto.Trim();

        Console.WriteLine("\n\tNome invalido!!!!!! Tente novamente");
    }
}

uint UInt(string enunciado)
{
    while (true)
    {
        Console.Write(enunciado);
        if (uint.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out uint result))
            return result;

        Console.WriteLine("\nIdade inválida!!!! Tente novamente");
    }
}

bool DesejaContinuar(string enunciado)
{
    string? texto;

    while (true)
    {
        Console.Write($"\n{enunciado} Sim/Não: ");
        texto = Console.ReadLine();

        if (!string.IsNullOrEmpty(texto))
        {
            if (texto.ToLower() == "sim")
                return true;

            if (texto.ToLower() == "não" || texto.ToLower() == "nao")
                return false;
        }

        Console.WriteLine("\nDecisão inválida!!!!! É SIM/NÃO!!!");
    }
}
