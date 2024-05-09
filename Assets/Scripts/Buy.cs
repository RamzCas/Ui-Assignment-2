using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buy : MonoBehaviour
{
    public Text Balance;
    public int Money;
    public Text SwordAmount;
    public int AmountOfSwords;
    public GameObject Sword;

    //public GameObject PackSpace1;
    //public GameObject PackSpace2;
    //public GameObject PackSpace3;
    //public GameObject PackSpace4;
    //public GameObject PackSpace5;
    //public GameObject PackSpace6;



    public void BuySword()
    {
        if (Money >= 30)
        {

            Money = Money - 30;
            Balance.text = Money.ToString();

            AmountOfSwords = AmountOfSwords - 1;
            SwordAmount.text = AmountOfSwords.ToString();

            //Sword.SetActive(true);
            //Sword.transform.position = PackSpace1.transform.position;
            

            Instantiate(Sword);
        }
    }
    public Text SheildAmount;
    public int AmountOfSheilds;
    public GameObject Shiled;
    public void BuySehild() 
    { 
        if (Money >= 25)
        {
         Money = Money -25; 
         Balance.text=Money.ToString();

         AmountOfSheilds = AmountOfSheilds - 1;
            SheildAmount.text = AmountOfSheilds.ToString();

            //Shiled.SetActive(true);
            Instantiate(Shiled);

        }
    }
    public Text PositionAmount;
    public int AmountOfPosition;
    public GameObject Position;

    public void BuyPosition() 
    {
    if (Money >= 5) 
        {
            Money = Money - 5;
            Balance.text=Money.ToString();

            AmountOfPosition = AmountOfPosition - 1;
            PositionAmount.text = AmountOfPosition.ToString();

            //Position.SetActive(true);
            Instantiate(Position);
        }
    }

    public Text ArmorAmount;
    public int AmountOfArmor;
    public GameObject Armor;

    public void BuyArmor() 
    {
    if(Money >= 50) 
        {
        Money = Money - 50;
        Balance.text=Money.ToString();

        AmountOfArmor = AmountOfArmor - 1;  
        ArmorAmount.text = AmountOfArmor.ToString();

            //Armor.SetActive(true);
            Instantiate(Armor);
        }
    }

    

    //public void BackPackView() 
    //{
    //    SceneManager.LoadScene("BackPack");
    //}

    //private void OnTriggerEnter2D(Collider2D coll)
    //{
    //    if(coll.gameObject == PackSpace1) 
    //    { 
    //     gameObject.transform.position = PackSpace2.transform.position;
    //    }

    //    else if(coll.gameObject == PackSpace2) 
    //    {
    //    gameObject.transform.position=PackSpace3.transform.position;
    //    }

    //    else if (coll.gameObject == PackSpace3) 
    //    {
    //    gameObject.transform.position = PackSpace4.transform.position;
    //    }

    //    else if (coll.gameObject == PackSpace4)
    //    {
    //    gameObject.transform.position = PackSpace5.transform.position;
    //    }

    //    else if( coll.gameObject == PackSpace5) 
    //    {
    //    gameObject.transform.position = PackSpace6.transform.position;
    //    }

    //    else 
    //    {
    //        return;
    //    }
    //}
}
