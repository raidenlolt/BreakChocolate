using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BreakChocolate
{
    //Inactive state do absolutly nothing.
    public class ChocolatePieceStateInactive : ChocolatePieceState
    {
        public ChocolatePieceStateInactive(ChocolatePiece piece)
            : base(piece)
        { 
        }
    }
}
