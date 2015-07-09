using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


namespace BreakChocolate
{
    // class that controls the logic flow of a chocolate piece.
    public class ChocolatePiece
    {
        ChocolatePieceHooks _hooks;
        ChocolatePieceStateFactory _stateFactory;
        ChocolatePieceState _state = null;

        public ChocolatePiece(ChocolatePieceHooks hooks)
        {
            _hooks = hooks;
            _stateFactory = new ChocolatePieceStateFactory();
        }

        public void Initialize()
        {
            //set the initial state
            _state = _stateFactory.Create(ChocolatePieceStates.ConnectedToBar, this);

            //register event handlers
            _hooks.OnClicked += OnClick;
            BreakButton.OnBreak += OnBreak;
        }

        public void ChangeState(ChocolatePieceStates state)
        {
            //stop current state and cleanup.
            if (_state != null)
                _state.Stop();

            //start new state.
            _state = _stateFactory.Create(state, this);
            _state.Start();
        }

        //select this piece
        public void SelectPiece()
        {
            CurrentSprite = SelectedSprite;
        }

        //Deselect this piece
        public void DeselectPiece(Sprite previouesSprite)
        {
            CurrentSprite = previouesSprite;
        }


        //handle on click event.
        void OnClick()
        {
            _state.OnClick();
        }

        //handle onbreak event.
        void OnBreak()
        {
            _state.OnBreak();
        }


        //Properties exposing variables from the ChocolatePieceHooks class.
        public Sprite CurrentSprite
        {
            get
            {
                return _hooks.GetComponent<SpriteRenderer>().sprite;
            }
            set
            {
                _hooks.GetComponent<SpriteRenderer>().sprite = value;
            }
        }

        public Sprite SelectedSprite
        {
            get
            {
                return _hooks.SelectedSprite;
            }
        }

        public Vector3 Position
        {
            get
            {
                return _hooks.transform.position;
            }
            set
            {
                _hooks.transform.position = value;
            }
        }

        public SpriteRenderer SpriteRenderer
        {
            get
            {
                return _hooks.GetComponent<SpriteRenderer>();
            }
        }
    }
}
