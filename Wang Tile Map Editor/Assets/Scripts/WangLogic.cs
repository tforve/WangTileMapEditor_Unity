using System.Collections.Generic;
using UnityEngine;

public class WangLogic : MonoBehaviour
{
    [SerializeField] private Grid grid;
    [SerializeField] private Sprite[] sprites;                  // for setting Sprites in UnityEidtor
    private int savedIndex;                                     // index of Tile on firstClick
    public Dictionary<int, Sprite> tileImages;                  // Dictionary of all possible TileSprites with correct HashKey

    private bool firstClick = true;                             // boolean to set first Tile to start new Island
    private int sum = 0;                                        // sum of Index to calculate correct Sprite

    //---------------------- Header END ----------------------


    void Start()
    {
        tileImages = new Dictionary<int, Sprite>();
        InitializeDictionary();
    }

    ///<summary> Save Index of first clicked Tile in Tilemenu</summary>
    public void SaveIndex(int value)
    {
        savedIndex = value;
        firstClick = true;
    }
    
    /// <summary>
    /// Calculating correct Tile via checking all Neighbors
    /// </summary>
    /// <param name="tile"> center tile that hast to calculate his Index</param>
    /// <returns></returns>
    public void CalculateIndex(Tile tile)
    {
        if (!firstClick)
        {
            sum = 0;

            // Checking all direct Neighbor Index if not 0 calculate new Weight in sum and know on wich side it has to be open
            if (grid.GetTileArray(tile.xPos, tile.yPos + 1).MyIndex != 0)             //NORTH
            {
                sum += 1;
            }
            if (grid.GetTileArray(tile.xPos + 1, tile.yPos).MyIndex != 0)             //EAST
            {
                sum += 4;
            }
            if (grid.GetTileArray(tile.xPos, tile.yPos - 1).MyIndex != 0)            //SOUTH
            {
                sum += 16;
            }
            if (grid.GetTileArray(tile.xPos - 1, tile.yPos).MyIndex != 0)            //WEST
            {
                sum += 64;
            }

            // checking all diagonal Neighbors 
            if (grid.GetTileArray(tile.xPos, tile.yPos + 1).MyIndex != 0 && grid.GetTileArray(tile.xPos + 1, tile.yPos).MyIndex != 0) //NE
            {
                if (grid.GetTileArray(tile.xPos + 1, tile.yPos + 1).MyIndex != 0)
                {
                    sum += 2;
                }
            }

            if (grid.GetTileArray(tile.xPos + 1, tile.yPos).MyIndex != 0 && grid.GetTileArray(tile.xPos, tile.yPos - 1).MyIndex != 0) //SE
            {
                if (grid.GetTileArray(tile.xPos + 1, tile.yPos - 1).MyIndex != 0)        //SE
                {
                    sum += 8;
   }
            }

            if (grid.GetTileArray(tile.xPos, tile.yPos - 1).MyIndex != 0 && grid.GetTileArray(tile.xPos - 1, tile.yPos).MyIndex != 0)  //SW
            {
                if (grid.GetTileArray(tile.xPos - 1, tile.yPos - 1).MyIndex != 0) //SW
                {
                    sum += 32;
                }
            }

            if (grid.GetTileArray(tile.xPos - 1, tile.yPos).MyIndex != 0 && grid.GetTileArray(tile.xPos, tile.yPos + 1).MyIndex != 0)  //NW
            {
                if (grid.GetTileArray(tile.xPos - 1, tile.yPos + 1).MyIndex != 0)        //NW
                {
                    sum += 128;
                }
            }
            if (sum > 255) { sum %= 255; }
        }
        
        else //choose first Tile
        {
            firstClick = false;
            sum = savedIndex;
        }
        
        tile.MyIndex = sum;

    }


    /// <summary>
    /// Get Sprite via Index
    /// </summary>
    /// <param name="index"> Index that is the Key to the Tilesprite in Dictionary</param>
    /// <returns></returns>
    public Sprite GetSprite(int index)
    {
        return tileImages[index];
    }

    ///<summary> adding Sprites to Dictionary with Haskey </summary>
    void InitializeDictionary()
    {
        tileImages.Add(0, sprites[0]);
        tileImages.Add(1, sprites[1]);
        tileImages.Add(4, sprites[2]);
        tileImages.Add(5, sprites[3]);
        tileImages.Add(7, sprites[4]);
        tileImages.Add(16, sprites[5]);
        tileImages.Add(17, sprites[6]);
        tileImages.Add(20, sprites[7]);
        tileImages.Add(21, sprites[8]);
        tileImages.Add(23, sprites[9]);
        tileImages.Add(28, sprites[10]);
        tileImages.Add(29, sprites[11]);
        tileImages.Add(31, sprites[12]);
        tileImages.Add(64, sprites[13]);
        tileImages.Add(65, sprites[14]);
        tileImages.Add(68, sprites[15]);
        tileImages.Add(69, sprites[16]);
        tileImages.Add(71, sprites[17]);
        tileImages.Add(80, sprites[18]);
        tileImages.Add(81, sprites[19]);
        tileImages.Add(84, sprites[20]);
        tileImages.Add(85, sprites[21]);
        tileImages.Add(87, sprites[22]);
        tileImages.Add(92, sprites[23]);
        tileImages.Add(93, sprites[24]);
        tileImages.Add(95, sprites[25]);
        tileImages.Add(112, sprites[26]);
        tileImages.Add(113, sprites[27]);
        tileImages.Add(116, sprites[28]);
        tileImages.Add(117, sprites[29]);
        tileImages.Add(119, sprites[30]);
        tileImages.Add(124, sprites[31]);
        tileImages.Add(125, sprites[32]);
        tileImages.Add(127, sprites[33]);
        tileImages.Add(193, sprites[34]);
        tileImages.Add(197, sprites[35]);
        tileImages.Add(199, sprites[36]);
        tileImages.Add(209, sprites[37]);
        tileImages.Add(213, sprites[38]);
        tileImages.Add(215, sprites[39]);
        tileImages.Add(221, sprites[40]);
        tileImages.Add(223, sprites[41]);
        tileImages.Add(241, sprites[42]);
        tileImages.Add(245, sprites[43]);
        tileImages.Add(247, sprites[44]);
        tileImages.Add(253, sprites[45]);
        tileImages.Add(255, sprites[46]);
    }
}
