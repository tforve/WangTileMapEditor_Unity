using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotControll : MonoBehaviour
{
    public GameObject slotControll;
    private GridLayoutGroup gridLayoutGrp;
    private int childCnt;

    void Start()
    {
        gridLayoutGrp = GetComponent<GridLayoutGroup>();
        childCnt = slotControll.transform.childCount;
    }

    void Update()
    {
        CheckTileFitting();
    }
    
    void CheckTileFitting()
    {
        if(childCnt > 40)
        {
            gridLayoutGrp.cellSize = new Vector2(32.0f,32.0f);
        }
    }
}
