using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    // ----- Grid related
    private RectTransform rt;                               // RectTransform Component of Grid to get width and height
    private int MAX_X, MAX_Y;                               // Max index in height and width (its twice+1 Tiles) depending on screensize and tileSize.
    private int MAX_Tiles_X, MAX_Tiles_Y;                   // amount of Tiles;
    [SerializeField] private Vector2 size;                  // Number of Tiles in X and Y direction. Should be later changeable for user
    private float indexSize = 32.0f;                        // its indexSize = 32;
    private float tileSize = 32.0f;                                 // Fix number from Sprite resolution indexSize * 2 +1. could be variable and get size from sprite himself maybe


    // ----- Tile related
    [SerializeField]
    private Index indexTile;
    [SerializeField]
    private Tile tile;
    

    //Array of Tiles for weight
    private Index[,] indexArray;
    private Tile[,] tileArray;

    //---------------------- Header END ----------------------

    void Start()
    {
        rt = this.GetComponent<RectTransform>();
        GenerateGrid();
    }

    ///<summary> Initialze the Grid with the correct width and height </summary>
    void GenerateGrid()
    {
        // has to be a multiple of 32*32 so that the indexArray fit in
        MAX_X = (int)(rt.rect.width / indexSize);
        MAX_Y = (int)(rt.rect.height / indexSize);

        MAX_Tiles_X = (MAX_X / 2) - 1;
        MAX_Tiles_Y = (MAX_Y / 2) - 1;

        //init indexArray[][] and tileArray[][]
        indexArray = new Index[MAX_X, MAX_Y];
        tileArray = new Tile[MAX_X, MAX_Y];

        //for Debuging purpose only right now
        size.x = MAX_X;
        size.y = MAX_Y;


        //Forloop to instantiate Tiles
          for (int x = 0; x < MAX_X; x++)
        {
            for (int y = 0; y < MAX_Y; y++)
            {
                //Index
                Tile tileTmp = Instantiate<Tile>(tile, new Vector3(x * tileSize, y * tileSize, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
                tileArray[x, y] = tileTmp;
            }
        }
        /*
        //Forloop to instantiate Index
        for (int x = 0; x < MAX_X; x++)
        {
            for (int y = 0; y < MAX_Y; y++)
            {
                //Index
                Index indexTmp = Instantiate<Index>(indexTile, new Vector3(x * indexSize, y * indexSize, 0), Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
                indexArray[x, y] = indexTmp;
            }
        }
         */

      
    }

    ///<summary> Reset Grid if you want to restart Level OR make new one etc </summary>
    void ResetGrid()
    {

    }

}
