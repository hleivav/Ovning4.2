using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ---------------------Frågor och svar------------------
// 2-3 När ökar listans kapacitet och med hur mycket? (Alltså den underliggande arrayens storlek) 
// Svar: kapaciteten ökar i takt med potenser av två. 
// Upp till 4 element på en lista på 4 (2 upphöjt till 2). Lägger man en till blir det 8 (2 upphöjt till 3). En nionde elemente utvidgas listan till 16 (2 upphöjt till 4)

// 4- Varför ökar inte listans kapacitet i samma takt som element läggs till?
// Svar: Jag gissar att det skulle ta onödiga resurser att kontrollera detta alltför ofta.

// 5- Minskar kapaciteten när element tas bort ur listan?
// Svar: Nej. 

// 6 - När är det då fördelaktigt att använda en egendefinierad array istället för en lista?
// Svar: När man vet hur många element man behöver som max.
//________________________________________________________

namespace SkalProj_Datastrukturer_Minne
{
    public  class menu1_examineTheList
    {
        private List<string> nameList; 
        public menu1_examineTheList()
        {
            nameList = new List<string>();
        }
        public  void ExamineList()
        {
            
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */


            String menuChoice = "Z";
            String menu1Input = ""; 
             
            do  
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("***********************ExaminList******************");
                    Console.WriteLine("Skriv tecknet '+' åtföljd av ett namn för att lägga till detta.");
                    Console.WriteLine("Skriv tecknet '-' åtföljd av ett namn för att få bort detta från listan");
                    Console.WriteLine("skriv 'E' för att gå tillbaka till huvudmenyn.");
                    Console.WriteLine("***********************ExaminList******************");
                    menu1Input = Console.ReadLine();
                    Console.WriteLine(menu1Input); 
               
                    switch (menuChoice)
                    {
                        case "+":
                        Console.WriteLine($"namnet som ska skickas till listan är: {menu1Input.Substring(1, menu1Input.Length-1)}");
                        nameList.Add(menu1Input.Substring(1, menu1Input.Length - 1));
                        Console.WriteLine(nameList.Capacity);
                        break;
                        case "-":
                        if (nameList.Contains(menu1Input.Substring(1, menu1Input.Length - 1)))
                        {
                            Console.WriteLine($"namnet som ska raderas från listan är: {menu1Input.Substring(1, menu1Input.Length - 1)}");
                            nameList.Remove(menu1Input.Substring(1, menu1Input.Length - 1));
                            Console.WriteLine(nameList.Capacity);
                        }

                        break;
                    default: Console.WriteLine("Välj '+' eller '-' bara");
                        break; 
                    }
                }
            while (menuChoice.ToUpper() != "E");
            Console.ForegroundColor = ConsoleColor.White;

            foreach(string x in nameList)
            {
                Console.WriteLine(x);
            }
        }

        /// <summary> 
        /// Examines the datastructure List
        /// </summary>
    }
}
