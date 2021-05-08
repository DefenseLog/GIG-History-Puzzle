using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PuzzleType
{
    Jigsaw,
    Tiles
}

[CreateAssetMenu(fileName = "New Puzzle Piece Object", menuName = "Inventory System/Items/Puzzle Piece")]
public class PuzzlePieceObject : ItemObject
{
    public int pieceNumber;
    public PuzzleType puzzleType;
    private void Awake()
    {
        type = ItemType.PuzzlePiece;
    }
}
