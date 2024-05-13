using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Buy : MonoBehaviour
{
    public RectTransform ParentRec;

    private void Start()
    {
     
    }



    public Text Balance;
    public int Money;
    public Text SwordAmount;
    public int AmountOfSwords;

    public GameObject Sword;

    public Button SwordButton;

    //public GameObject PackSpace1;
    //public GameObject PackSpace2;
    //public GameObject PackSpace3;
    //public GameObject PackSpace4;
    //public GameObject PackSpace5;
    //public GameObject PackSpace6;

    public Vector3 BuyArea;
    public Vector3 scale;

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
            
           // Instantiate(Sword);
           //Sword = (GameObject) Instantiate(Sword,BuyArea,Quaternion.identity);
           SpawnSword();
          
        }
        if (AmountOfSwords <= 0)
        {
            SwordButton.interactable = false;
        }

        if(AmountOfSwords >= 1) 
        {
            SwordButton.interactable = true; 
        }
    }

    public GameObject Parent;
    public RectTransform SwordRec;
    public void SpawnSword() 
    {
       GameObject NewSpawnSword = Instantiate(Sword,BuyArea,Quaternion.identity);
       NewSpawnSword.transform.parent = Parent.transform;
       //swordPng.rectTransform.sizeDelta = new Vector2(1, 1);
             

    }

    public void RefundSword() 
    {
    Money = Money + 30;
    Balance.text = Money.ToString();

    AmountOfSwords = AmountOfSwords + 1;
    SwordAmount.text = AmountOfSwords.ToString();

        //DestroyImmediate(Sword);
      
    }



    public Text SheildAmount;
    public int AmountOfSheilds;
    public GameObject Shiled;
    public Button ShieldButton;
    public void BuySehild() 
    { 
        if (Money >= 25)
        {
         Money = Money -25; 
         Balance.text=Money.ToString();

         AmountOfSheilds = AmountOfSheilds - 1;
            SheildAmount.text = AmountOfSheilds.ToString();

            //Shiled.SetActive(true);
            //Instantiate(Shiled);
            //Shiled = (GameObject)Instantiate(Shiled, BuyArea, Quaternion.identity);
            SpawnShield();

        }

        if(AmountOfSheilds <= 0) 
        {
        ShieldButton.interactable = false;
        }

        if (AmountOfSheilds >= 1)
        {
            ShieldButton.interactable = true;
        }
    }
    public void SpawnShield()
    {
        GameObject NewSpawnSword = Instantiate(Shiled, BuyArea, Quaternion.identity);
        NewSpawnSword.transform.parent = Parent.transform;
    }

    public void RefundSheild()
    {
        Money = Money + 25;
        Balance.text = Money.ToString();

        AmountOfSheilds = AmountOfSheilds + 1;
        SheildAmount.text = AmountOfSheilds.ToString();

    }

    public Text PositionAmount;
    public int AmountOfPosition;
    public GameObject Position;
    public Button PotionButton;
    public void BuyPosition()
    {
        if (Money >= 5)
        {
            Money = Money - 5;
            Balance.text = Money.ToString();

            AmountOfPosition = AmountOfPosition - 1;
            PositionAmount.text = AmountOfPosition.ToString();

            //Position.SetActive(true);
            //Instantiate(Position);
            //Position = (GameObject)Instantiate(Position, BuyArea, Quaternion.identity);
            SpawnPotion();
        }

        if (AmountOfPosition <= 0) 
        {
            Debug.Log("stop");   
            PotionButton.interactable = false;

            if (AmountOfPosition >= 1)
            {
                PotionButton.interactable = true;
            }
        }
    }

    public void SpawnPotion()
    {
        GameObject NewSpawnSword = Instantiate(Position, BuyArea, Quaternion.identity);
        NewSpawnSword.transform.parent = Parent.transform;
      
    }

    public void RefundPotion()
    {
        Money = Money + 5;
        Balance.text = Money.ToString();

        AmountOfPosition = AmountOfPosition + 1;
        PositionAmount.text = AmountOfPosition.ToString();
    }

    public Text ArmorAmount;
    public int AmountOfArmor;
    public GameObject Armor;
    public Button ArmorButton;

    public void BuyArmor() 
    {
    if(Money >= 50) 
        {
        Money = Money - 50;
        Balance.text=Money.ToString();

        AmountOfArmor = AmountOfArmor - 1;  
        ArmorAmount.text = AmountOfArmor.ToString();

            //Armor.SetActive(true);
            // Instantiate(Armor);
            //Armor = (GameObject)Instantiate(Armor, BuyArea, Quaternion.identity);
            SpawnArmour();
        }
        if (AmountOfArmor <= 0)
        {
            ArmorButton.interactable = false;
        }

        if(AmountOfArmor >= 1) 
        {
        ArmorButton.interactable=true;
        }
    }

    public void SpawnArmour()
    {
        GameObject NewSpawnSword = Instantiate(Armor, BuyArea, Quaternion.identity);
        NewSpawnSword.transform.parent = Parent.transform;
    }

    public void RefundArmour()
    {
        Money = Money + 50;
        Balance.text = Money.ToString();

        AmountOfArmor = AmountOfArmor + 1;
        ArmorAmount.text = AmountOfArmor.ToString();
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
