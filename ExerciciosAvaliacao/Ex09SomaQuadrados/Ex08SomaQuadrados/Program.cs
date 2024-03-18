/*Exercício 9: Soma dos Quadrados:
Dada uma lista de números, utilize LINQ para calcular a soma dos quadrados dos números.*/

using System.Globalization;

List<double> numeros;
double soma;

do
{
    Console.Clear();
    Console.WriteLine("\nExercicio 08 - Tutorial 15");

    numeros = [];

    do
    {
        numeros.Add(Double("\nQual número deseja inserir?: "));

    } while (DesejaContinuar("Deseja adicionar outro número?"));

    soma = numeros.Select(n => n * n).Sum();

    Console.WriteLine($"\nA soma dos quadrados dos números inseridos é {soma}");

} while (DesejaContinuar("Deseja inserir outra lista de números, para ver a soma dos seus quadrados?"));

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
