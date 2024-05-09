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
}
