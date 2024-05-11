using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    public GameObject ShopCam;
    public GameObject PackCam;

    public void SwitchToShop() 
     {
     PackCam.SetActive(false);
     ShopCam.SetActive(true);
     }

     public void SwitchToPack()
     { 
     PackCam.SetActive(true); 
     ShopCam.SetActive(false);
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


    public float Calculation(float celsius)
    {
     float thatNumber = 273.15f;
     float kelvin = celsius + thatNumber;

        return kelvin;
 
    }

}
