using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    // ----- Grid related
    [SerializeField]
    private Vector2 size;                   // Number of Tiles in X and Y direction. Should be later changeable for user
    private float tileSize = 32.0f;         // Fix number from Sprite resolution. could be variable and get size from sprite himself maybe
    private float MAX_X, MAX_Y;             // Max Tiles in height and width depending on screensize and tileSize

    // ----- Tile related
    [SerializeField]
    private Tile tile;

    //Array of Tiles for wight
    private Tile[][] tiles;

    //---------------------- Header END ----------------------
    
    void Start()
    {
       GenerateGrid();
    }

    void Update()
    {
        ResetGrid();
    }

    void GenerateGrid()
    {
        MAX_X = Screen.width / tileSize;
        MAX_Y = Screen.height / tileSize;

        //for Debuging purpose 
        size.x = MAX_X;
        size.y = MAX_Y;

        for (int x = 0; x < MAX_X; x++)
        {
            for (int y = 0; y < MAX_Y; y++)
            {
                Tile tmp = Instantiate<Tile>(tile, new Vector3(x * tileSize, y * tileSize, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
                // tiles[x][y] = tmp;
                // Debug.Log(tiles[x]);
            }
        }
    }

    void ResetGrid()
    {

    }

}
