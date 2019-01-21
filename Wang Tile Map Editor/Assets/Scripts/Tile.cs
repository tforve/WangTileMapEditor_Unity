using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Tile : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    private Image image;

    public Image MyImage
    {
        get { return image; }
        set { image = value; }
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
