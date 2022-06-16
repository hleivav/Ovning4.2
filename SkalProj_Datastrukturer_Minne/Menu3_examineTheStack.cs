using System.Collections;
// Fråga 1 - Simulera ännu en gång ICA-kön på papper. Denna gång med en stack . Varför är det
//inte så smart att använda en stack i det här fallet?
//Svar: Med stack metoden hade de som kommit först i kön hanterats sist.

namespace SkalProj_Datastrukturer_Minne
{
    internal class Menu3_examineTheStack
    {
        Stack <string>icaStack = new Stack<string>();

        public void ReverseText()
        {
            Console.WriteLine("Skriv en textsträng: ");
            string userInput = Console.ReadLine();
            foreach (char c in userInput) icaStack.Push(c.ToString());
            foreach (string s in icaStack) Console.WriteLine(s);

        }
    }

    
}