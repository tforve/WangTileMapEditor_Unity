using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WangLogic : MonoBehaviour
{
    [SerializeField] private Grid grid;
    [SerializeField] private Dictionary<int, Sprite> tileImages;
    [SerializeField] private Sprite[] sprites;

    // public Sprite img0, img1, img04, img05, img07, img16, img17, img20, img21, img23, img28, img29;
    // public Sprite img31, img64, img65, img68, img69, img71, img80, img81, img84, img85, img87, img92;
    // public Sprite img93, img95, img112, img113, img116, img117, img119, img124, img125, img127;
    // public Sprite img193, img197, img199, img209, img213, img215, img221, img223, img241, img245, img247, img253, img255;

    void Start()
    {
        tileImages = new Dictionary<int, Sprite>();

        InitializeDictionary();

        
        // Debug.Log("" + tileImages[64]);
        //Debug.Log(grid.MyTileArray(0, 0).MyIndex);
    }

    //Methode called by Clicking Tile
    public void SetTileImage(Tile tile)
    {

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
