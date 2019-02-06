using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Tile : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
    private Image image;
    [SerializeField] private int index;
    [HideInInspector] public int xPos, yPos;

    private Text text;
    [SerializeField] private WangLogic wangLogic;

    //---------------------- Header END ----------------------

    //get Index of Tile and Change it to new one to set Tile Image
    public int MyIndex
    {
        get { return index; }
        set { index = value; }
    }
    //---------------------- Properties END -------------------
    
    void Awake()
    {
        image = GetComponent<Image>();
        text = GetComponentInChildren<Text>();
        wangLogic = FindObjectOfType<WangLogic>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        wangLogic.CalculateIndex(this);

        //place Tile by setting new Image
        image.sprite = wangLogic.GetSprite(MyIndex);
        text.text = "" + index;
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
