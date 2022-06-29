using System.Collections.Generic;

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
    }
}
