/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
   string[] produtos = {
            "1 - Pão Francês",
            "2 - Café em Pó",
            "3 - Arroz Branco",
            "4 - Feijão Preto",
            "5 - Leite Integral",
            "0 - Finalizar atendimento"
        };

        Console.WriteLine("=== MERCADO DO BRASILEIRO ===\n");
        
        foreach (string produto in produtos)
        {
            Console.WriteLine(produto);
        }

        Console.Write("\nSelecione o item desejado (1 a 5) ou 0 para finalizar: ");
        string entrada = Console.ReadLine();

        if (int.TryParse(entrada, out int escolha))
        {
            if (escolha >= 1 && escolha <= 5)
            {
                int indice = escolha - 1;
                
                Console.WriteLine($"\nProduto selecionado: {produtos[indice]}");
                
                Console.WriteLine("\n--- Digite seu endereço para entrega ---");
                
                Console.Write("Cidade: ");
                string cidade = Console.ReadLine();
                
                Console.Write("Bairro: ");
                string bairro = Console.ReadLine();
                
                Console.Write("Número: ");
                string numero = Console.ReadLine();
                
                Console.WriteLine("\n--- Resumo do pedido ---");
                Console.WriteLine($"Produto: {produtos[indice]}");
                Console.WriteLine($"Endereço de entrega:");
                Console.WriteLine($"Cidade: {cidade}");
                Console.WriteLine($"Bairro: {bairro}");
                Console.WriteLine($"Número: {numero}");
                
                Console.WriteLine("\nPedido registrado com sucesso!");
                
                Console.WriteLine("\nPressione ENTER para finalizar...");
                Console.ReadLine();
            }
            else if (escolha == 0)
            {
                Console.WriteLine("\nAtendimento finalizado. Obrigado pela preferência!");
                Console.WriteLine("\nPressione ENTER para finalizar...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nOpção inválida! Programa finalizado.");
                Console.WriteLine("\nPressione ENTER para finalizar...");
                Console.ReadLine();
            }
        }
        else
        {
            Console.WriteLine("\nOpção inválida! Programa finalizado.");
            Console.WriteLine("\nPressione ENTER para finalizar...");
            Console.ReadLine();
        }
    }
   
  }
  
