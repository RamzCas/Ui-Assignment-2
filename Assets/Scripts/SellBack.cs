using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;


public class SellBack : MonoBehaviour
{
    public GameObject sword; 
    public GameObject shield;
    public GameObject potion;
    public GameObject armor;

    public Camera cam;

   public Buy sell;

    public void Update()
    {
        /*if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Refund");
            
          
           
        }*/
    }

    Vector3 MousWorldPos()
    {
        var mouseScreenPos = Input.mousePosition;
        mouseScreenPos.z = Camera.main.WorldToScreenPoint(transform.position).z;
        return Camera.main.ScreenToWorldPoint(mouseScreenPos);
    }
}
