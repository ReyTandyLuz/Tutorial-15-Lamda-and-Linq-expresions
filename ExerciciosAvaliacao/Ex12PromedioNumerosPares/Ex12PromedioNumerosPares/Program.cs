/*Exercício 12: Média dos Números Pares:
Dada uma lista de números, utilize LINQ para calcular a média dos números pares.*/

using System.Globalization;

List<double> numeros;
double media;

do
{
    Console.Clear();
    Console.WriteLine("\nExercicio 12 - Tutorial 15");

    numeros = [];

    do
    {
        numeros.Add(Double("\nQual número deseja inserir?: "));

    } while (DesejaContinuar("Deseja adicionar outro número?"));

    Console.WriteLine(ProcessamentoDaLista(numeros));

} while (DesejaContinuar("Deseja inserir outra lista de números, para ver a média dos seus números pares?"));

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

string ProcessamentoDaLista(List<double> numeros)
{
    string resposta;

    try
    {
        media = numeros.Where(n => n % 2 == 0).Average();

        resposta = $"\nA média dos números pares dos números inseridos é {media:n1}";
    }
    catch (InvalidOperationException)
    {
        resposta = "\nNenhum dos números inseridos é par ._.";
    }
    catch (Exception ex)
    {
        resposta = "\nErro inseperado: " + ex.Message;
    }

    return resposta;
}

