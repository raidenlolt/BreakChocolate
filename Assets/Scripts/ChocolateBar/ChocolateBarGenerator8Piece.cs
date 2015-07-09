using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace BreakChocolate
{
    // generate a 2X4 chocolate bar
    public class ChocolateBarGenerator8Piece : ChocolateBarGenerator
    {
        public ChocolateBarGenerator8Piece()
        {
            gridOffsets = new Vector2[2, 4] 
            { 
                { new Vector2(-1.5f, -0.5f), new Vector2(-0.5f, -0.5f), new Vector2(0.5f, -0.5f), new Vector2(1.5f, -0.5f) }, 
                { new Vector2(-1.5f, 0.5f), new Vector2(-0.5f, 0.5f), new Vector2(0.5f, 0.5f), new Vector2(1.5f, 0.5f) } 
            };

            rows = 2;
            columns = 4;
        }
    }
}
