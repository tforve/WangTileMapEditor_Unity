using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Tile : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    private Image image;
    [SerializeField] private int index;
    [HideInInspector] public int xPos, yPos;

    private Text text;
    private Grid grid;
    [SerializeField] private WangLogic wangLogic;

    //get Index of Tile and Change it to new one to set Tile Image
    public int MyIndex
    {
        get { return index; }
        set { index = value; }
    }

    //Constructor
    public Tile(Image image, int index, int x, int y)
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
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        // has to give X,Y pos and Weight 
        wangLogic.CalculateIndex(this, index);

        //place Tile by setting new Image
        image.sprite = wangLogic.GetSprite(MyIndex);

        text.text = "" + index;

        //check correct Wang
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //Highlight by Change Cholor of image
        image.color = new Color(0.5f, 1.0f, 0.5f, 1.0f);

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //stop highlighting 
        image.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);

    }
}
