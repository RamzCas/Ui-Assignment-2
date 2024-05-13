using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockGrid : MonoBehaviour
{

    public GameObject Pack1;
    public GameObject Pack2;
    public GameObject Pack3;
    public GameObject Pack4;
    public GameObject Pack5;
    public GameObject Pack6;

   
    /* private void OnTriggerEnter2D(Collider2D coll)
     {
         if (coll.gameObject) 
         {
         coll.transform.position = transform.position;
             Debug.Log("Placed");
         }
     }*/
    private bool isObjectSelected = false;
    private GameObject selectedObject;
    private Vector3 initialObjectPos;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
           // Debug.Log("click");
            Vector2 raycastPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(raycastPoint, Vector2.zero);

            if (hit.collider != null) 
            {
            if(hit.collider.CompareTag("Sword")) 
                {
                    Debug.Log("Move Sword");
                    /* selectedObject = hit.collider.gameObject;
                     initialObjectPos = selectedObject.transform.position;
                     isObjectSelected = true;*/
                    GameObject swordObject = hit.collider.gameObject;
                    swordObject.transform.position = Pack1.transform.position;
                }
            }
        }

        
        
    }
}