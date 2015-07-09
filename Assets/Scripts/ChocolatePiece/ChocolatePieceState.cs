using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace BreakChocolate
{
    public enum ChocolatePieceStates
    {
        ConnectedToBar,
        Selected,
        Broken,
        Inactive,
    }

    //all state classes inherit from this class.
    public abstract class ChocolatePieceState
    {
        protected ChocolatePiece _chocolatePiece;

        public ChocolatePieceState(ChocolatePiece piece)
        {
            _chocolatePiece = piece;
        }

        public virtual void Start()
        {
        }

        public virtual void Stop()
        {
        }

        public virtual void OnClick()
        {
            // do nothing
        }

        public virtual void OnBreak()
        {
            // do nothing
        }
    }
}
