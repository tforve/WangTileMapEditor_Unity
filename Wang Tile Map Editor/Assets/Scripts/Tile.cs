using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Tile : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{

    private Image image;
    private int index;

    private Text text;
    private Grid grid;
    [SerializeField]private WangLogic wangLogic;

    public Image MyImage
    {
        get { return image; }
        set { image = value; }
    }

    //get Index of Tile and Change it to new one to set Tile Image
    public int MyIndex
    {
        get { return index; }
        set { index = value; }
    }


    //Constructor
    public Tile (Image image, int index)
    {
        image = this.image;
        index = this.index;
    }

    void Awake()
    {
        image = GetComponent<Image>();
        text = GetComponentInChildren<Text>();
        grid = GetComponentInParent<Grid>();
        wangLogic = FindObjectOfType<WangLogic>();
        index = 0;
        //RandomIndex();
    }

    void RandomIndex()
    {
        int rndNumber = Random.Range(0, 2);
        index = rndNumber;
        text.text = "";// + rndNumber;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //place Tile by setting new Image
        image.sprite = wangLogic.GetSprite(64);
        //check correct Wang
        //gibt sich selbst an WangLogic zurück???
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //show tile or just use Button and Highlight Tile
        //Highlight by Change Cholor of image
        image.color = new Color(0.5f, 1.0f, 0.5f, 1.0f);

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //stop highlighting 
        image.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);

    }
}
