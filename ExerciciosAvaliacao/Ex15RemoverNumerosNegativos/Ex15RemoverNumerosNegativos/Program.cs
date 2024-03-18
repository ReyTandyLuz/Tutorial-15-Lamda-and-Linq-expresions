/*Exercício 15: Remoção de Números Negativos:
Dada uma lista de números, utilize LINQ para criar uma nova lista removendo os números negativos.*/

using System.Globalization;

List<double> numeros, numerosPositivos;

do
{
    Console.Clear();
    Console.WriteLine("\nExercicio 15 - Tutorial 15");

    numeros = [];

    do
    {
        numeros.Add(Double("\nQual número deseja inserir?: "));

    } while (DesejaContinuar("Deseja adicionar outro número?"));

    numeros = [.. numeros.Order()];
    numerosPositivos = [.. numeros.Where(n => n > 0 - 1)];

    if (numerosPositivos.Count == 0)
        Console.WriteLine("\nNenhum número inserido era positivo");

    else if (numeros.Count == numerosPositivos.Count)
        Console.WriteLine("\nNenhum dos números inseridos são negativos");

    else if (numerosPositivos.Count == 1)
        Console.WriteLine($"\nO único número inserido positivo foi {numerosPositivos[0]}");

    else
        Console.WriteLine($"\nOs número positivos encontrados forom:\n\t {string.Join("\n\t", numerosPositivos)}");

} while (DesejaContinuar("Deseja inserir outra lista de números?"));

double Double(string enunciado)
{
    while (true)
    {
        Console.Write(enunciado);
        if (double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out double result) && result != -0)
            return result;

        Console.WriteLine("\nNúmero inválido!!!! Tente novamente");
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
