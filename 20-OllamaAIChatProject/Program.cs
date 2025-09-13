using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.AI;
using OllamaSharp;

class Program
{
    static async Task Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("=== Ollama AI Chat Project ===");
        Console.ResetColor();
        Console.WriteLine("Model: phi3:mini (localhost:11434)");
        Console.WriteLine("Çıkmak için 'exit' yazın.\n");

        IChatClient chatClient = new OllamaApiClient(new Uri("http://localhost:11434"), "phi3:mini");

        List<ChatMessage> chatMessages = new();

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Sen: ");
            Console.ResetColor();
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
                continue;

            if (input.ToLower() == "exit")
                break;

            chatMessages.Add(new ChatMessage(ChatRole.User, input));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("AI: ");
            Console.ResetColor();

            string response = "";
            await foreach (ChatResponseUpdate item in chatClient.GetStreamingResponseAsync(chatMessages))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(item.Text);
                Console.ResetColor();
                response += item.Text;
            }

            chatMessages.Add(new ChatMessage(ChatRole.Assistant, response));
            Console.WriteLine("\n");
        }

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\nSohbet sona erdi. Görüşmek üzere!");
        Console.ResetColor();
    }
}
