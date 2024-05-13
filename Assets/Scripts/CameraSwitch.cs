using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public GameObject ShopText;
    public GameObject BabckpackText;
    public GameObject BabckpackText2;

    public GameObject SwitchToChestText;

    public GameObject Instructios;
    public void SwitchToShop() 
     {
        Camera.main.transform.position = Shop;
        Item1.SetActive(true);
        Item2.SetActive(true);
        Item3.SetActive(true);
        Item4.SetActive(true);

        ShopText.SetActive(true);
        BabckpackText.SetActive(true);

        SwitchToChestText.SetActive(true);

        Instructios.SetActive(true);

        BabckpackText2.SetActive(false);
     }

     public void SwitchToPack()
     {
        Camera.main.transform.position = Inventory;
        Item1.SetActive(false);
        Item2.SetActive(false);
        Item3.SetActive(false);
        Item4.SetActive(false);

        ShopText.SetActive(false);
        BabckpackText.SetActive(false);

        SwitchToChestText.SetActive(false);

        Instructios.SetActive(false);

        BabckpackText2.SetActive(true);
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
