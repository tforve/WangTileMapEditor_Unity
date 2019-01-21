using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    [SerializeField]
    private Vector2 size;
    private float tileSize = 32.0f;

    [SerializeField]
    private Tile tile;

    //Array of Tiles
    private Tile[][] tiles;

    void Start()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        for (int x = 0; x < size.x; x++)
        {
            for (int y = 0; y < size.y; y++)
            {
               Tile tmp = Instantiate<Tile>(tile, new Vector3(x*tileSize,y*tileSize,0), Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
//               tiles[x][y] = tmp;
              // Debug.Log(tiles[x]);
            }
        }
    }

}
