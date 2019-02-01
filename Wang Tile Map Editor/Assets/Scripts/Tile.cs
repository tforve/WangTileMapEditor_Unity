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

    void Awake()
    {
        text = GetComponentInChildren<Text>();
        RandomIndex();
    }

    void RandomIndex()
    {
        int rndNumber = Random.Range(0, 2);
        index = rndNumber;
        text.text = "" + rndNumber;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        //place Tile by setting new Image
        //check correct Wang
        Debug.Log("Clicked");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        //show tile or just use Button and Highlight Tile
        //Highlight by Change Cholor of image
        GetComponent<Image>().color = new Color(0.5f, 1.0f, 0.5f, 1.0f);

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        //stop highlighting 
        GetComponent<Image>().color = new Color(1.0f, 1.0f, 1.0f, 1.0f);

    }
}
