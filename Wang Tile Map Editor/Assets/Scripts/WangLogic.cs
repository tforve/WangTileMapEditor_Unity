using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WangLogic : MonoBehaviour
{
    private Image image;                    //Image get from tile
    [SerializeField] private Grid grid;

    //Get Array of Tiles
    private Tile[,] tileArray;

    void Start()
    {
        //Debug.Log(grid.MyTileArray(0, 0).MyIndex);
    }

    //Methode called by Clicking Tile
    public void SetTileImage(Tile tile)
    {

    }
}
