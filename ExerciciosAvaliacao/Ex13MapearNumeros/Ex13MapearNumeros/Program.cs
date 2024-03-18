/*Exercício 13: Mapeamento de Números:
Dada uma lista de números, utilize LINQ para criar uma nova lista onde cada número é multiplicado por 2.*/

using System.Globalization;

List<double> numeros, numerosMultiplicados;

do
{
    Console.Clear();
    Console.WriteLine("\nExercicio 13 - Tutorial 15");

    numeros = [];   

    do
    {
        numeros.Add(Double("\nQual número deseja inserir?: "));

    } while (DesejaContinuar("Deseja adicionar outro número?"));

    numeros = [.. numeros.Order()];
    numerosMultiplicados = [.. numeros.Select(n => n * 2).Order()];

    Console.WriteLine($"\nOs números inseridos já multiplicados vezes dois são: \n");

    for(int i = 0; i < numeros.Count; i++)
        Console.WriteLine($"\t{numeros[i]} -> {numerosMultiplicados[i]}");

} while (DesejaContinuar("Deseja inserir outra lista de números?"));

double Double(string enunciado)
{
    while (true)
    {
        Console.Write(enunciado);
        if (double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out double result))
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
