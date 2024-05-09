using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class SellBack : MonoBehaviour
{
    public GameObject sword; 
    public GameObject shield;
    public GameObject potion;
    public GameObject armor;

    public void Refund() 
    {
         if (Input.GetMouseButtonDown(1) ==true)
        {
            Debug.Log("sell");
        }
    }
}
