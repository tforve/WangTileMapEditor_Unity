using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotScript : MonoBehaviour
{

    private Outline outline;
    private Tile tile;              // get Tile so i can get the Image of it

    public Tile MyTile
    {
        get {return tile;}
    }


    // Start is called before the first frame update
    void Start()
    {
        outline = GetComponent<Outline>();
    }

    // mark Image beneathe mouse
    public void SelectTile()
    {
        outline.enabled = outline.enabled == false ? true : false;

        // have to get the Tile 

    }
}
