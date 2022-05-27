using System.Collections;

namespace SkalProj_Datastrukturer_Minne
{
    internal class Menu3_examineTheStack
    {
        Stack <string>icaStack = new Stack<string>();

        public void ReverseText()
        {
            Console.WriteLine("Skriv en textsträng: ");
            string userInput = Console.ReadLine();
            icaStack.Push(userInput);
            Console.WriteLine(icaStack.Count);

            //while (icaStack.Count > 0)
            //{
                
            //}
        }
    }

    
}