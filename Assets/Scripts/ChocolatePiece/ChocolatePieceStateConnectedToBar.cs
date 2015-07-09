using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace BreakChocolate
{
    public class ChocolatePieceStateConnectedToBar : ChocolatePieceState
    {
        public ChocolatePieceStateConnectedToBar(ChocolatePiece piece)
            : base(piece)
        {
        }

        public override void OnClick()
        {
            //this piece has been selected.
            Debug.Log("[ChocolatePieceStateConnectedToBar:OnClick]");
            _chocolatePiece.ChangeState(ChocolatePieceStates.Selected);
        }

        public override void OnBreak()
        {
            //this piece was no selected so should be counted as given to 2nd character.
            Debug.Log("[ChocolatePieceStateConnectedToBar:OnBreak]");
            _chocolatePiece.ChangeState(ChocolatePieceStates.Inactive);
            GameData.NumberofPiecesforCharacter2++;
        }
    }
}
