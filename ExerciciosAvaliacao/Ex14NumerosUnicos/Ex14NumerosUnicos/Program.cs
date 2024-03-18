/*Exercício 14: Números Únicos:
Dada uma lista de números, utilize LINQ para criar uma nova lista contendo apenas os números únicos.*/

using System.Globalization;

List<double> numeros, numerosUnicos;

do
{
    Console.Clear();
    Console.WriteLine("\nExercicio 14 - Tutorial 15");

    numeros = [];

    do
    {
        numeros.Add(Double("\nQual número deseja inserir?: "));

    } while (DesejaContinuar("Deseja adicionar outro número?"));

    numeros = [.. numeros.Order()];
    numerosUnicos = [.. numeros.ToHashSet()];
   
    if (numerosUnicos.Count == 1)
        Console.WriteLine($"\nO único número único é {numerosUnicos[0]}");

    else if (numerosUnicos.Count > 1)
        Console.WriteLine($"\nOs números únicos são:\n {string.Join("\n\t", numerosUnicos)}");

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
