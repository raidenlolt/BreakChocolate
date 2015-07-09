using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace BreakChocolate
{
    //the piece has been selected.
    public class ChocolatePieceStateSelected : ChocolatePieceState
    {
        private Sprite _previousSprite;

        public ChocolatePieceStateSelected(ChocolatePiece piece)
            : base(piece)
        {
        }

        public override void Start()
        {
            //store the sprite to reset if deselected.
            Debug.Log("[ChocolatePieceStateSelected:Start]");
            _previousSprite = _chocolatePiece.CurrentSprite;
            _chocolatePiece.SelectPiece();
        }

        public override void OnClick()
        {
            //piece deselected. 
            Debug.Log("[ChocolatePieceStateSelected:OnClick]");
            _chocolatePiece.DeselectPiece(_previousSprite);
            _chocolatePiece.ChangeState(ChocolatePieceStates.ConnectedToBar);
        }

        public override void OnBreak()
        {
            //piece has been broken.
            Debug.Log("[ChocolatePieceStateSelected:OnBreak]");
            _chocolatePiece.ChangeState(ChocolatePieceStates.Broken);
            GameData.NumberofPiecesforCharacter1++;
        }
    }
}
