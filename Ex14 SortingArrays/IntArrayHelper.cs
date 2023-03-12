using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14_SortingArrays
{
    public class IntArrayHelper
    {


        // Vi vil gerne lave en metode
        // Så et array bliver udskrevet i rigtig rækkefølge -> 1,2,3,4

        public void Sort(int[] intArray)
        {
            // Skal bruges til midlertidigt at kunne tildeles, hvis værdien vi er på [i] er højere end [j].
            // vi skal altså kunne placere værdien midlertidigt for at gøre "plads" til den andens værdi
            int temp = 0;

            // Fra literaturen:
            // We will take two for loops; first, a for loop for checking the   
            // first position of an array and iterating the length of the array. 
            // The second loop starts with the i+1 position and iterates the length of the array.

            // Første for løkke starter ved [0]
            for (int i = 0; i <= intArray.Length - 1; i++)
            {
                // Næste for løkke starter ved [1]
                // Meningen med dette, er at vi i vores "if" condition nedenunder skal sammenligne disse to tal.
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    // Hvis [i] er større end [j] skal programmet gå denne vej
                    if (intArray[i] > intArray[j])
                    {
                        // Vores temp, altså vores midlertidige tal = [i]
                        temp = intArray[i];
                        // Vores [i] = [j] - vi har placeret den oprindelige [i] i vores temp. Så der er "plads" til,
                        // at vores [j] kan komme ind og overtage denne plads.
                        intArray[i] = intArray[j];
                        // [j] får nu tildelt den værdi vi havde i [i]
                        intArray[j] = temp;
                        // De to tal har nu skiftet plads.
                        // Hvis [i] ikke var større end [j] havde vores program været "tilfreds" og var gået videre med at
                        // iterere i forløkken
                    }
                }
            }

            // For hvert int i[0,1,2....] i vores intArray[] 
            foreach (int i in intArray)
            {
                Console.WriteLine(i);
            }
        }

        // Vi laver nu endnu en metode hvor den blot udskriver i omvendt rækkefølge. Altså med højeste tal først
        // De to metoder ligner hinanden på en prik - den eneste forskel er at vi i vores if-statement ændre operator  '>' til '<'
        // Så der står intArray[i] < intArray[j]

        public void Reverse(int[] intArray)
        {
            
            int temp = 0;

            for (int i = 0; i <= intArray.Length - 1; i++)
            {
                for (int j = i + 1; j < intArray.Length; j++)
                {
                    if (intArray[i] < intArray[j])
                    {  
                        temp = intArray[i];
                        intArray[i] = intArray[j];
                        intArray[j] = temp;
                    }
                }
            }
            foreach (int i in intArray)
            {
                Console.WriteLine(i);
            }
        }




    }
}
