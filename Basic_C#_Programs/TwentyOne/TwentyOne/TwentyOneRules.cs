using System.Collections.Generic;
using System.Linq;

namespace TwentyOne
{
    internal class TwentyOneRules
    {
        //privat methods are used only within the class in wich it was created.
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>() // create the method and also instanciate it at the same time.
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1,
        };

        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace); // lambda expresion loops all faces in the hand and return the count number where the condition is meet(in this case, how many aces are in the hand)
            int[] result = new int[aceCount + 1]; // create an array
            int value = Hand.Sum(x => _cardValues[x.Face]); // lambda expresion to summ the faces
            result[0] = value;
            if (result.Length == 1) return result; // if can be writen in one line if only one line of logic is used
            for (int i = 1; i < result.Length; i++)
            {
                value += (i * 10);
                result[i] = value;
            }
            return result;
        }

        public static bool CheckForBlackJack(List<Card> Hand)
        {

        }
    }
}
