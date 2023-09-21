using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_Wilson_Kenny
{
    internal class Card
    {

        /// <summary>
        /// Prints the cards in your hand and into the stack.
        /// </summary>

        public string Number { get; }


        public string Suit { get; }


        public Card(string numParam, string suitParam)
        {
            Number = numParam;
            Suit = suitParam;
        }




    }
}
