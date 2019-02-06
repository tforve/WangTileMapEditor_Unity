using UnityEngine;
using UnityEngine.UI;

public class SlotScript : MonoBehaviour
{
    private WangLogic wangLogic;

    [SerializeField] private int index;

    // Start is called before the first frame update
    void Start()
    {
        wangLogic = FindObjectOfType<WangLogic>();
    }

    public void SaveIndex()
    {
        wangLogic.SaveIndex(index);
    }
}
