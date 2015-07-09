using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine.Assertions;

namespace BreakChocolate
{
    // class used to create appropriate generator class.
    public class ChocolateBarGeneratorFactory
    {
        //supported no. of pieces in the bar.
        public int[] NumberofPiecesRange = { 4, 6, 8, 9, 12 };

        public ChocolateBarGeneratorFactory()
        {
        }

        //create the generator according to no of pieces.
        public ChocolateBarGenerator Create(ChocolateBar bar, int noOfPieces)
        {
            switch (noOfPieces)
            {
                case 4:
                    return new ChocolateBarGenerator4Piece();
                case 6:
                    return new ChocolateBarGenerator6Piece();
                case 8:
                    return new ChocolateBarGenerator8Piece();
                case 9:
                    return new ChocolateBarGenerator9Piece();
                case 12:
                    return new ChocolateBarGenerator12Piece();
            }

            Assert.IsTrue(false);
            return null;
        }
    }
}
