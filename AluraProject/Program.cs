using Microsoft.VisualBasic;
using System;
using System.Runtime.Intrinsics.Arm;
using System.Threading.Tasks.Sources;
using System.Xml;
using System.Threading;
using System.Collections.Generic;


// Screen Sound 
string mensagemdeboasbindas = "Boas bindas ao Screen Sound";
List<string> listaDasBandas = new List<string> { "U2", "Banda Calypso" };

void ExibirMensagem()
    {
       Console.WriteLine("...");
       Console.WriteLine(mensagemdeboasbindas);
      
    }

//função 
void ExibirOpcoesdoMenu ()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");


    //capturando o comando pessoa usuária
    Console.Write("\n Digite uma opção: ");
    string opcaoEscolhida = Console.ReadLine();
    // Convertendo String em inteiro
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    //Condição para retorno
   // if (opcaoEscolhidaNumerica == 1)
  //  {
       // Console.WriteLine("Você digitou a opção " + opcaoEscolhida);
  //  }
   // else if (opcaoEscolhidaNumerica == 2)
   // {
       // Console.WriteLine("Você digitou a opção " + opcaoEscolhida);

   // }
   switch (opcaoEscolhidaNumerica)
    {
        case 1: Registrarbanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: Console.WriteLine("Você escolheu a opção" + opcaoEscolhida);
            break;
        case 4: Console.WriteLine("Você escolheu a opção" + opcaoEscolhida);
            break;
        case -1: Console.WriteLine("Você escolheu a opção" + opcaoEscolhida);
            break;
        default: Console.WriteLine("Opção invalida");
            break;

    }
}

//função
void Registrarbanda()
    {
            Console.Clear();
            Console.WriteLine("\nRegistro de bandas");
            Console.WriteLine("Digite o nome da banda que deseja registrar");
            string nomeDaBanda = Console.ReadLine()!;
            listaDasBandas.Add(nomeDaBanda);
            Console.WriteLine($" A Banda {nomeDaBanda} foi registrada com sucesso");
            Thread.Sleep(2000);
            Console.Clear();
            ExibirOpcoesdoMenu();
}

//função
void MostrarBandasRegistradas()
    {
        Console.Clear();
        Console.WriteLine("*****************************************");
        Console.WriteLine("Exibindo todas as bandas registradas");
        Console.WriteLine("*****************************************\n");

        // For Tradicional
        // for (int i = 0; i < listaDasBandas.Count; i++)
        //{
        //  Console.WriteLine($"Banda: {listaDasBandas[i]}");
        //}
        foreach (string banda in listaDasBandas)
        {
        Console.WriteLine($"banda: {banda}");
        }
        
        Console.WriteLine("\nDigite um tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesdoMenu();
        
    }



ExibirMensagem();
ExibirOpcoesdoMenu();