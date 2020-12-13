using System;
using AulaPOO_PolimorfismoSobrecarga.classes;

namespace AulaPOO_PolimorfismoSobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = true;
            Funcionario func = new Funcionario();
            while(sair){
                Console.WriteLine("Escolha a operacao");
                Console.WriteLine("1 - mostrar lista");
                Console.WriteLine("2 - Mostrar índice");
                Console.WriteLine("3 - Fazer busca");
                Console.WriteLine("Digite 0 para sair");
                switch (Console.ReadLine()){
                    case "0":
                        sair = false;
                        break;
                    case "1":
                        func.Mostrar();
                        break;
                    case "2":
                        Console.WriteLine("Qual o numero de cadastro que voce deseja ver?");
                        func.Mostrar(Console.ReadLine());
                        break;
                    case "3":
                        break;
                    default:
                        break;
                }
                
            }
        }
    }
}
