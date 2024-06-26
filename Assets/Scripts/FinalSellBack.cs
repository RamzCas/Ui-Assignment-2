using UnityEngine;
using UnityEngine.EventSystems;

public class FinalSellBack : MonoBehaviour, IDropHandler
{
    public Buy sell;

    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        Dragable dragable = dropped.GetComponent<Dragable>();
        dragable.parentAfterDrag = transform;
        
        if (dropped.CompareTag("Sword")) 
        {
            Debug.Log("swords");
            sell.RefundSword();
            Destroy(dropped);
        }

        if (dropped.CompareTag("Sheild")) 
        {
            Debug.Log("Sheild");
            sell.RefundSheild();
            Destroy(dropped);
        }

        if (dropped.CompareTag("Potion")) 
        {
            Debug.Log("Potion");
            sell.RefundPotion();
            Destroy(dropped);
        }

        if (dropped.CompareTag("Armour")) 
        {
            Debug.Log("armour");
            sell.RefundArmour();
            Destroy(dropped);
        }

        if(dropped.CompareTag("Arrow"))
        {
            Debug.Log("Arrow");
            sell.RefundArrow(); 
            Destroy(dropped);
        }

        if (dropped.CompareTag("Dagger")) 
        {
            Debug.Log("Dagger");
            sell.RefundDagger();
            Destroy(dropped);
        }

        if (dropped.CompareTag("TheOnePiece"))
        {
            Debug.Log("OnePiece");
            sell.RefundOnePiece();
            Destroy(dropped);
        }

        
    }
}
