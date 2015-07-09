using System;
using UnityEngine;

namespace BreakChocolate
{
    public class ChocolatePieceStateBroken : ChocolatePieceState
    {
        public ChocolatePieceStateBroken(ChocolatePiece piece)
            : base(piece)
        {
        }

        public override void Start()
        {
            //Hide the piece.
            Debug.Log("[ChocolatePieceStateBroken:Start]: here");
            _chocolatePiece.SpriteRenderer.enabled = false;
        }
    }
}
