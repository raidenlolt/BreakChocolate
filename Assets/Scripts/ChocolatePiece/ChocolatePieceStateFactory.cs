using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine.Assertions;

namespace BreakChocolate
{
    //class used to create new states.
    public class ChocolatePieceStateFactory
    {
        public ChocolatePieceStateFactory()
        {
        }

        public ChocolatePieceState Create(ChocolatePieceStates state, ChocolatePiece piece)
        {
            switch (state)
            {
                case ChocolatePieceStates.ConnectedToBar:
                    return new ChocolatePieceStateConnectedToBar(piece);
                case ChocolatePieceStates.Selected:
                    return new ChocolatePieceStateSelected(piece);
                case ChocolatePieceStates.Broken:
                    return new ChocolatePieceStateBroken(piece);
                case ChocolatePieceStates.Inactive:
                    return new ChocolatePieceStateInactive(piece);
            }

            Assert.IsTrue(false);
            return null;
        }
    }
}
