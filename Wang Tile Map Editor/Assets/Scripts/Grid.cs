using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    // ----- Grid related
    private RectTransform rt;                               // RectTransform Component of Grid to get width and height
    private float MAX_X, MAX_Y;                             // Max Tiles in height and width depending on screensize and tileSize
    [SerializeField] private Vector2 size;                  // Number of Tiles in X and Y direction. Should be later changeable for user
    private float tileSize = 32.0f;                         // Fix number from Sprite resolution. could be variable and get size from sprite himself maybe

    // ----- Tile related
    [SerializeField]
    private Tile tile;

    //Array of Tiles for weight
    private Tile[][] tiles;

    //---------------------- Header END ----------------------

    void Start()
    {
        rt = this.GetComponent<RectTransform>();
        GenerateGrid();
    }

    ///<summary> Initialze the Grid with the correct width and height </summary>
    void GenerateGrid()
    {
        // has to be a multiple of 32*32 so that the tiles fit in
        MAX_X = rt.rect.width  / tileSize;   //Screen.width / tileSize;
        MAX_Y = rt.rect.height / tileSize;  //Screen.height / tileSize;

        //for Debuging purpose 
        size.x = MAX_X;
        size.y = MAX_Y;

        for (int x = 0; x < MAX_X; x++)
        {
            for (int y = 0; y < MAX_Y; y++)
            {
                Tile tmp = Instantiate<Tile>(tile, new Vector3(x * tileSize, y * tileSize, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
               // tiles[x][y] = tmp;
            }
        }
    }

    ///<summary> Reset Grid if you want to restart Level OR make new one etc </summary>
    void ResetGrid()
    {

    }

}
