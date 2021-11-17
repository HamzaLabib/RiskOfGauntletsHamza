using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GridMng : MonoBehaviour
{
    public Grid grid;
    public Transform bomb;
    public Tilemap distructible;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DeleteTile();
    }

    void DeleteTile()
    {
        Vector3Int position = grid.WorldToCell(bomb.position);
        distructible.SetTile(position, null);
    }
}
