using System.Collections;
// Jag kunde inte hitta nån bra metod att loopa igenom elementen i en Queue eller en Stack. 
// Tanken var att loppa igenom en queue med en foreach och hitta en metod som först fångade den aktuella elementet i listan
// för att sen hitta denna i en (Enum var det tänkt, men funkade inte) array som innehöll alla parenteser i ordning. 
// hittade man t ex tecknet "(" fick man gå tre steg i listan får att få fram ")". 
// Jag behövde då veta vilken nästa element i listan var men jag kunde inte komma åt listan med ett index, vad jag förstod. 
// Alltså, jag behövde accesa queue listan med en for loop, så att jag kunde jämföra nästa element i listan, men det kunde inte jag.
// Jag funderade sen på att använda en for loop och utföra operationen innan jag la in elementen i queue, men jag anar att det inte var meningen med övningen.

namespace SkalProj_Datastrukturer_Minne
{
    internal class Menu4_checkParenthesis

    {
        Queue parenthesesQueue = new Queue();
        private char[] parenthesis = {'{', '[', '(', '}', ']', ')'};
        char currentChar = ' ';
        char nextChar = ' ';
        char opositeParenthesis = ' '; 
        bool parenthesisFound = false;

        public void checkParenthesis()
        {
            Console.WriteLine("Skriv en textsträng: ");
            string userInput = Console.ReadLine();
            foreach (char c in userInput)
            {
                parenthesesQueue.Enqueue(c);
            }
            foreach (char p in parenthesesQueue)
            {
                currentChar = p;
                for (int i = 0; i < 2; i++)
                {
                    if (currentChar == parenthesis[i])
                    {
                        opositeParenthesis = parenthesis[i + 3];
                        parenthesisFound = true;    
                    }
                    else
                    {
                        parenthesisFound = false; 
                    }
                }  
                if (parenthesisFound == true && currentChar != nextChar) { }
                
                //parenthesis.Contains(currentChar)
                  
            }
        }

    }
    
}