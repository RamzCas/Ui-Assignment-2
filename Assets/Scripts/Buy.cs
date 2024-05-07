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

    public void BuySword()
    {
        if (Money >= 50)
        {

            Money = Money - 30;
            Balance.text = Money.ToString();

            AmountOfSwords = AmountOfSwords - 1;
            SwordAmount.text = AmountOfSwords.ToString();

            Sword.SetActive(true);
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

            Shiled.SetActive(true);
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

            Position.SetActive(true);
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

        Armor.SetActive(true);
        }
    }

    public void BackPackView() 
    {
        SceneManager.LoadScene("BackPack");
    }
}
