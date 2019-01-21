using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.UIElements;

public class Cell : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private Image icon;
    
    
    public Image MyIcon
    {
        get {return icon;} 
        set {icon = value;}
    }

    void Start()
    {
    
    }
    
    void ChangeIcon()
    {
        Debug.Log("ICH BIN EINE CELL, WOHOasdasdasd");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
        {
            Debug.Log("ICH BIN EINE CELL, WOHOasdasdasd");
        }

        ChangeIcon();
    }
}
