using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace BreakChocolate
{
    // generate a 2x2 chocolate bar
    public class ChocolateBarGenerator4Piece : ChocolateBarGenerator
    {
        public ChocolateBarGenerator4Piece()
        {
            gridOffsets = new Vector2[2, 2] 
            { 
                { new Vector2(-0.5f, -0.5f), new Vector2(0.5f, -0.5f) }, 
                { new Vector2(-0.5f, 0.5f), new Vector2(0.5f, 0.5f) } 
            };

            rows = 2;
            columns = 2;
        }

    }
}
