using System.Collections;

namespace SkalProj_Datastrukturer_Minne
{
    internal class Menu2_examineTheQueue
    {
        Queue icaQueue = new Queue();
        int personCounter = 0;
        public Menu2_examineTheQueue()
        {

        }
        public void TestQueue()
        {

            string menuChoice = "Z"; 
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("***********************QueueList******************");
                Console.WriteLine("Skriv tecknet '+' för att lägga till en ny element i kön.");
                Console.WriteLine("Skriv tecknet '-' för att ta bort en element från kön.");
                Console.WriteLine("skriv 'E' för att gå tillbaka till huvudmenyn.");
                Console.WriteLine("***********************QueueList******************");
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "+":
                        personCounter++;
                        icaQueue.Enqueue(personCounter);
                        break;
                    case "-":
                        if (icaQueue.Count > 0) icaQueue.Dequeue();
                        break;
                    default:
                        Console.WriteLine("Välj '+' eller '-' bara");
                        break;
                }
            }
            while (menuChoice.ToUpper() != "E");
            foreach (Object item in icaQueue) Console.WriteLine(item);
            Console.ForegroundColor = ConsoleColor.White; 
        }
    }
}