using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace BreakChocolate
{
    // class used to acess the chocolate piece game object
    // unity engine related data and functions.
    [RequireComponent(typeof(SpriteRenderer))]
    [RequireComponent(typeof(BoxCollider2D))]
    public class ChocolatePieceHooks : MonoBehaviour
    {
        //the event fired when this game object is clicked
        public delegate void ClickAction();
        public event ClickAction OnClicked;

        //the sprite to used when selected.
        public Sprite SelectedSprite;
 
        void OnMouseDown()
        {
            //fire the onclicked event.
            Debug.Log("[ChocolatePieceHooks:OnMouseDown]");
            if (OnClicked != null)
                OnClicked();
        }
    }
}
