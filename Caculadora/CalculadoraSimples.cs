namespace Caculadora;

public class CalculadoraSimples
{


    static void Main()
    {
        Console.WriteLine("--------------- Caculadora Simples ---------------");
        Menu();
    }

    public static void Menu()
    {
        Console.WriteLine("Qual des seguintes operações deseja realizar:\n1-Soma\n2-Subtração\n3-Multiplicação\n4-Divisão\n0-Sair");
        int opt = int.Parse(Console.ReadLine()!);
        Console.WriteLine("---------------------------------------------------");
        
        switch (opt)
        {
            case 0:
            {   
                Console.WriteLine("Encerrando o sistema !");
                break;
            }
            case 1:
            {
                Soma();
                
                Menu();
                break;
            }
            case 2:
            {
                Subtracao();
                Menu();
                break;
            }
            
            case 3:
            {
                Multiplicacao();
                Menu();
                break;
            }
            case 4:
            {
                Divisao();
                Menu();
                break;
            }
            default:
                Console.WriteLine("A operação selecionada é inválida !");
                Menu();
                break;
        }

    }

    public static void Soma()
    {
        Console.Clear();
        
        Console.WriteLine("Digite um número: ");
        float num1 = float.Parse(Console.ReadLine()!);
        
        Console.WriteLine("Digite outro número: ");
        float num2 = float.Parse(Console.ReadLine()!);

        float soma = num1 + num2;

        Console.WriteLine($"O valor da soma:\n{num1} + {num2} = {soma}");
        Thread.Sleep(2000);
        Console.Clear();
    }
    
    public static void Subtracao()
    {
        Console.Clear();
        
        Console.WriteLine("Digite um número: ");
        float num1 = float.Parse(Console.ReadLine()!);
        
        Console.WriteLine("Digite outro número: ");
        float num2 = float.Parse(Console.ReadLine()!);

        float subtração = num1 - num2;

        Console.WriteLine($"Resultado da subtração:\n{num1} - {num2} = {subtração}");
        Thread.Sleep(2000);
        Console.Clear();
    }

    public static void Multiplicacao()
    {

        Console.Clear();
        
        Console.WriteLine("Digite um número: ");
        float num1 = float.Parse(Console.ReadLine()!);
        
        Console.WriteLine("Digite outro número: ");
        float num2 = float.Parse(Console.ReadLine()!);

        float multiplicacao = num1 * num2;

        Console.WriteLine($"Resultado da multiplicação:\n{num1} * {num2} = {multiplicacao}");
        Thread.Sleep(2000);
        Console.Clear();
    }
    
    public static void Divisao()
    {
        Console.Clear();
        
        Console.WriteLine("Digite um número: ");
        float num1 = float.Parse(Console.ReadLine()!);
        
        Console.WriteLine("Digite outro número: ");
        float num2 = float.Parse(Console.ReadLine()!);

        float divisao = num1 / num2;

        Console.WriteLine($"Resultado da divisão:\n{num1} / {num2} = {divisao}");
        Thread.Sleep(2000);
        Console.Clear();
    }
}