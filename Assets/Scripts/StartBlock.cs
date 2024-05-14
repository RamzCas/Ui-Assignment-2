using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class StartBlock : MonoBehaviour, IDropHandler
{
    public Button Item1;
    public Button Item2;
    public Button Item3;
    public Button Item4;
    public Button Item5;
    public Button Item6;
    public Button Item7;
    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            GameObject dropped = eventData.pointerDrag;
            Dragable dragable = dropped.GetComponent<Dragable>();
            dragable.parentAfterDrag = transform;
        }

        if (transform.childCount ==0) 
        {
            Debug.Log("occupied");
        }
    }
}
