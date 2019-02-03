using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotScript : MonoBehaviour
{
    private WangLogic wangLogic;

    private Outline outline;
    [SerializeField] private int index;

    // Start is called before the first frame update
    void Start()
    {
        outline = GetComponent<Outline>();
        wangLogic = FindObjectOfType<WangLogic>();
    }

    public void SaveIndex()
    {
        wangLogic.SaveIndex(index);
    }

    // mark Image beneathe mouse
    public void SelectTile()
    {
        outline.enabled = outline.enabled == false ? true : false;
    }
}
