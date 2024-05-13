using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    //public GameObject ShopCam;
   // public GameObject PackCam;

    public Vector3 Inventory;
    public Vector3 Shop;

    public GameObject Item1;
    public GameObject Item2;
    public GameObject Item3;
    public GameObject Item4;

    public void SwitchToShop() 
     {
        Camera.main.transform.position = Shop;
        Item1.SetActive(true);
        Item2.SetActive(true);
        Item3.SetActive(true);
        Item4.SetActive(true);
     }

     public void SwitchToPack()
     {
        Camera.main.transform.position = Inventory;
        Item1.SetActive(false);
        Item2.SetActive(false);
        Item3.SetActive(false);
        Item4.SetActive(false);
     }


    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))   
        {
           SwitchToPack();
            Debug.Log("BackPack Cam");
        }

        if(Input.GetKeyUp(KeyCode.Escape)) 
        {
        SwitchToShop();
            Debug.Log("Shop Cam");
        }
    }


   
    // I work in class lol

    /* public float Calculation(float celsius)
    {
     float thatNumber = 273.15f;
     float kelvin = celsius + thatNumber;

        return kelvin;
 
    }*/

}
