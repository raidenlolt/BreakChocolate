using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace BreakChocolate
{
    //generate a 2x3 chocolate bar
    public class ChocolateBarGenerator6Piece : ChocolateBarGenerator
    {
        public ChocolateBarGenerator6Piece()
        {
            gridOffsets = new Vector2[2, 3] 
            { 
                { new Vector2(-1f, -0.5f), new Vector2(0f, -0.5f), new Vector2(1f, -0.5f) }, 
                { new Vector2(-1f, 0.5f), new Vector2(0f, 0.5f), new Vector2(1f, 0.5f) } 
            };

            rows = 2;
            columns = 3;
        }
    }
}
