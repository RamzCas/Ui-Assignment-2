using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PurchasBlock : MonoBehaviour
{
    public Button Item1;
    public Button Item2;
    public Button Item3;
    public Button Item4;

    
    public void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject)
        {
            Debug.Log("Purchas In Progress");
            Item1.interactable = false;
            Item2.interactable = false;
            Item3.interactable = false;
            Item4.interactable = false;
        }
    }

    private void OnTriggerExit2D(Collider2D coll)
    {
        Debug.Log("Purchas Complete");
        Item1.interactable= true;
        Item2.interactable= true;
        Item3.interactable= true;
        Item4.interactable= true;
    }

   

}
