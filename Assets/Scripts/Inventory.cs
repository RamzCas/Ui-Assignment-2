using UnityEngine;
using UnityEngine.EventSystems;

public class Inventory : MonoBehaviour, IDropHandler
{    
    public void OnDrop(PointerEventData eventData)
    {
        if (transform.childCount == 0)
        {
            GameObject dropped = eventData.pointerDrag;
            Dragable dragable = dropped.GetComponent<Dragable>();
            dragable.parentAfterDrag = transform;
        }
    }
}
