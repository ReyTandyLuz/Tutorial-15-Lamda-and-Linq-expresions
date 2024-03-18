/*Exercício 10: Números Primos:
Dada uma lista de números, utilize LINQ para selecionar e imprimir apenas os números primos.*/

using System.Globalization;

List<int> numeros;

do
{
    Console.Clear();
    Console.WriteLine("\nExercicio 10 - Tutorial 15");

    numeros = [];

    do
    {
        numeros.Add(Int("\nQual número deseja inserir?: "));

    } while (DesejaContinuar("Deseja adicionar outro número?"));

    numeros = [..numeros.Where(n => EPrimo(n)).Order()];

    if (numeros.Count == 0)
        Console.WriteLine("\nNenhum número dos que forom inseridos é primo");

    else if (numeros.Count == 1)
        Console.WriteLine($"\nO único número primo achado na lista é {numeros[0]}");

    else
        Console.WriteLine($"\nOs números primos achados forom {string.Join(',', numeros)}");

} while (DesejaContinuar("Deseja inserir outra lista de números, para ver quais são números primos?"));

int Int(string enunciado)
{
    while (true)
    {
        Console.Write(enunciado);
        if (int.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out int result))
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

bool EPrimo(int numero)
{
    if (numero == 1 || numero == -1 || numero == 0)
        return false;

    for(int i = 2; i < numero; i++)
    {
        if (numero % i == 0)
            return false;
    }

    return true;
}

