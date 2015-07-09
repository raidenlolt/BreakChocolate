using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace BreakChocolate
{
    // generate a 3x3 chocolate bar
    public class ChocolateBarGenerator9Piece : ChocolateBarGenerator
    {
        public ChocolateBarGenerator9Piece()
        {
            gridOffsets = new Vector2[3, 3] 
            { 
                { new Vector2(-1f, -1f), new Vector2(0f, -1f), new Vector2(1f, -1f) }, 
                { new Vector2(-1f, 0f), new Vector2(0f, 0f), new Vector2(1f, 0f) }, 
                { new Vector2(-1f, 1f), new Vector2(0f, 1f), new Vector2(1f, 1f) }
            };

            rows = 3;
            columns = 3;
        }
    }
}
