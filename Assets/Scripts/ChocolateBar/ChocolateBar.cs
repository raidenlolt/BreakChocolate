using System;
using System.Collections.Generic;
using UnityEngine;


namespace BreakChocolate
{
    // This class is used to store the pieces
    public class ChocolateBar
    {
        private List<ChocolatePiece> _chocolatePieces;
        private ChocolateBarHooks _hooks;

        public ChocolateBar(ChocolateBarHooks hooks)
        {
            _hooks = hooks;
        }

        public Vector3 Position 
        {
            get
            {
                return _hooks.transform.position;
            }
        }

        public List<ChocolatePiece> PieceList
        {
            get
            {
                return _chocolatePieces;
            }
            set
            {
                _chocolatePieces = value;
            }
        }

    }
}
