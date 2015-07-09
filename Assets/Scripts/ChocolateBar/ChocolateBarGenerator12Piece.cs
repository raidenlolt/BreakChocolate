using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace BreakChocolate
{
    // generate a 3x4 chocolate bar
    public class ChocolateBarGenerator12Piece : ChocolateBarGenerator
    {
        public ChocolateBarGenerator12Piece()
        {
            gridOffsets = new Vector2[3, 4] 
            { 
                { new Vector2(-1.5f, -1f), new Vector2(-0.5f, -1f), new Vector2(0.5f, -1f), new Vector2(1.5f, -1f) }, 
                { new Vector2(-1.5f, 0f), new Vector2(-0.5f, 0f), new Vector2(0.5f, 0f), new Vector2(1.5f, 0f) },
                { new Vector2(-1.5f, 1f), new Vector2(-0.5f, 1f), new Vector2(0.5f, 1f), new Vector2(1.5f, 1f) },
            };

            rows = 3;
            columns = 4;
        }
    }
}
