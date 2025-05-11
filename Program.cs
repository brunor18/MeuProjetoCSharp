using System;

class Program
{
    static void Main()
    {
        while(true)
        {
            Console.WriteLine("Calculadora - bruno ribeiro\n");
            Console.WriteLine("Selecione uma opção:");
            Console.WriteLine("1. +");
            Console.WriteLine("2. -");
            Console.WriteLine("3. X");
            Console.WriteLine("4. /");
            Console.WriteLine("5. Sair do programa");
            int option = Convert.ToInt32(Console.ReadLine());

            if(option == 1){
                Console.Clear();
                adicionar();
            }
            else if(option == 2){
                Console.Clear();
                subtrair();
            }
            else if(option == 3){
                Console.Clear();
                multi();
            }
            else if(option == 4){
                Console.Clear();
                div();
            }
            else if(option == 5){
                Console.WriteLine("Saindo do programa...");
                Thread.Sleep(800);
                break;
            }
            else{
                Console.WriteLine("Opção inválida");
                Thread.Sleep(800);
                Console.Clear();
            }
        }
        
    }

    static void adicionar(){
        Console.WriteLine("Digite o primeiro número:");
        double firstnumber = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        double secondnumber = Convert.ToDouble(Console.ReadLine());

        double soma = firstnumber + secondnumber;

        Console.WriteLine("A soma dos dois números é:" + soma);

        Console.WriteLine("Voltando ao menu...");
        Thread.Sleep(1000);
        Console.Clear();

    }

    static void subtrair(){
        Console.WriteLine("Digite o primeiro número:");
        double firstnumber = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        double secondnumber = Convert.ToDouble(Console.ReadLine());

        double dif = firstnumber - secondnumber;

        Console.WriteLine("A diferença dos dois números é:" + dif);
        
        Console.WriteLine("Voltando ao menu...");
        Thread.Sleep(1000);
        Console.Clear();

    }

    static void multi(){
        Console.WriteLine("Digite o primeiro número:");
        double firstnumber = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        double secondnumber = Convert.ToDouble(Console.ReadLine());

        double mul = firstnumber * secondnumber;

        Console.WriteLine("A multiplicação dos dois números é:" + mul);
        
        Console.WriteLine("Voltando ao menu...");
        Thread.Sleep(1000);
        Console.Clear();
    }

    static void div(){
        Console.WriteLine("Digite o primeiro número:");
        double firstnumber = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        double secondnumber = Convert.ToDouble(Console.ReadLine());

        if(secondnumber == 0){
            Console.WriteLine("Impossível dividir por zero\n");
        }

        else{
            double div = firstnumber / secondnumber;
            Console.WriteLine("A divisão dos dois números é:" + div);
        }
        
        
        Console.WriteLine("Voltando ao menu...");
        Thread.Sleep(2000);
        Console.Clear();
    }


}
