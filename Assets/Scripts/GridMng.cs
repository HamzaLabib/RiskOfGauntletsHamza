using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridMng : MonoBehaviour
{
    public Grid grid;
    public Tilemap distructible;

    public void DeleteTile(Transform bomb, int explosionRange)
    {
        Vector3Int position = grid.WorldToCell(bomb.position);

        /*List<Vector3Int> range = new List<Vector3Int>();
        for (int i = 0; i < explosionRange; i++)
        {
            Vector3Int topRightcells = position.Set(explosionRange + i, explosionRange + i, 0);
            Vector3Int downLeftCells = position.Set(explosionRange - i, explosionRange - i, 0);
            range.Add(topRightcells);
            range.Add(downLeftCells);
        }

        foreach (Vector3Int cell in range)
        {
            distructible.SetTile(cell, null);
            range.Remove(cell);
        }*/

        distructible.SetTile(position, null);
    }
}
