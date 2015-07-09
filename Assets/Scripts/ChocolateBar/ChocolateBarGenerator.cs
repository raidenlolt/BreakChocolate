using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace BreakChocolate
{
    // this class is used to generate chocolate bars.
    // inherit this class and define gridOffsets, row and columns variables accordingly.
    public abstract class ChocolateBarGenerator
    {
        public ChocolateBarGenerator()
        {
        }

        public virtual List<ChocolatePiece> CreateBar(ChocolateBar bar, GameObject prefab)
        {
            List<ChocolatePiece> pieces = new List<ChocolatePiece>();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    //Instantiate the prefab for chocolate piece. Then get the script component to pass to conststructor
                    //for the class that controls the piece. then add to the list.
                    GameObject hooksGO = GameObject.Instantiate(prefab, Vector3.zero, Quaternion.identity) as GameObject;
                    ChocolatePieceHooks hooks = hooksGO.GetComponent<ChocolatePieceHooks>();
                    ChocolatePiece chocolatePiece = new ChocolatePiece(hooks);
                    chocolatePiece.Initialize();
                    float width = chocolatePiece.SpriteRenderer.sprite.bounds.size.x;
                    float height = chocolatePiece.SpriteRenderer.sprite.bounds.size.y;
                    float offsetX = gridOffsets[i, j].x * width;
                    float offsetY = gridOffsets[i, j].y * height;
                    Vector3 offset = new Vector3(offsetX, offsetY);
                    chocolatePiece.Position = bar.Position + offset;
                    pieces.Add(chocolatePiece);
                }
            }

            return pieces;
        }

        protected Vector2[,] gridOffsets;
        protected int rows;
        protected int columns;
    }
}
