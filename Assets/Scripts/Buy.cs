using UnityEngine;
using UnityEngine.UI;


public class Buy : MonoBehaviour
{
    public RectTransform ParentRec;

    private void Start()
    {
     
    }

    public Text Balance;
    public int Money = 100;
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
        if (Money >= 50)
        {
            Money = Money - 50;
            Balance.text = Money.ToString();

            AmountOfArmor = AmountOfArmor - 1;
            ArmorAmount.text = AmountOfArmor.ToString();

            //Armor.SetActive(true);
            // Instantiate(Armor);
            //Armor = (GameObject)Instantiate(Armor, BuyArea, Quaternion.identity);
            SpawnArmour();

          
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

    public Text ArrowAmount;
    public int AmountOfArrows;
    public GameObject Arrow;
    public Button ArrowButton;

    public void BuyArrow()
    {
        if (Money >= 15)
        {
            Money = Money - 15;
            Balance.text = Money.ToString();

            AmountOfArrows = AmountOfArrows - 1;
            ArrowAmount.text = AmountOfArrows.ToString();

            SpawnArrow();   
        }
    }
    public void SpawnArrow()
    {
        GameObject NewSpawnSword = Instantiate(Arrow, BuyArea, Quaternion.identity);
        NewSpawnSword.transform.parent = Parent.transform;
    }

    public void RefundArrow() 
    {
        Money = Money + 15;
        Balance.text = Money.ToString();

        AmountOfArrows = AmountOfArrows + 1;
        ArrowAmount.text = AmountOfArrows.ToString();
    }


    public Text DaggerAmount;
    public int AmountOfDaggers;
    public GameObject Dagger;
    public Button DaggerButton;
    public void BuyDagger()
    {
        if (Money >= 75)
        {
            Money = Money - 75;
            Balance.text = Money.ToString();

            AmountOfDaggers = AmountOfDaggers - 1;
            DaggerAmount.text = AmountOfDaggers.ToString();

            SpawnDagger();
        }
    }
    public void SpawnDagger()
    {
        GameObject NewSpawnSword = Instantiate(Dagger, BuyArea, Quaternion.identity);
        NewSpawnSword.transform.parent = Parent.transform;
    }

    public void RefundDagger()
    {
        Money = Money + 75;
        Balance.text = Money.ToString();

        AmountOfDaggers = AmountOfDaggers + 1;
        DaggerAmount.text = AmountOfDaggers.ToString();
    }

    public Text OnePieceAmount;
    public int AmountOfOnePiece;
    public GameObject OnePiece;
    public Button OnePieceButton;

    public void BuyOnePiece()
    {
        if (Money >= 100)
        {
            Money = Money - 100;
            Balance.text = Money.ToString();

            AmountOfOnePiece = AmountOfOnePiece - 1;
            OnePieceAmount.text = AmountOfOnePiece.ToString();

            SpawnOnePiece();
        }
    }
    public void SpawnOnePiece()
    {
        GameObject NewSpawnSword = Instantiate(OnePiece, BuyArea, Quaternion.identity);
        NewSpawnSword.transform.parent = Parent.transform;
    }

    public void RefundOnePiece()
    {
        Money = Money + 100;
        Balance.text = Money.ToString();

        AmountOfOnePiece = AmountOfOnePiece + 1;
        OnePieceAmount.text = AmountOfOnePiece.ToString();
    }


    public int AmountOfSPace;
    public Text SpaceAmount;
    public GameObject InventorySlot;
    public Button InventorySlotButton;

    public GameObject ChestParent;
    private int SpaceCounter;

    public GameObject slot1;
    public GameObject slot2;
    public GameObject slot3;
    public GameObject slot4;


    public void BuySpace()
    {
        SpaceCounter++;
        if (Money >= 10)
        {
            if (SpaceCounter == 1)
            {
                Money = Money - 10;
                Balance.text = Money.ToString();

                AmountOfSPace = AmountOfSPace - 1;
                SpaceAmount.text = AmountOfSPace.ToString();

                slot1.SetActive(true);
            }
            if (SpaceCounter == 2)
            {
                Money = Money - 10;
                Balance.text = Money.ToString();

                AmountOfSPace = AmountOfSPace - 1;
                SpaceAmount.text = AmountOfSPace.ToString();

                slot2.SetActive(true);
            }
            if (SpaceCounter == 3)
            {
                Money = Money - 10;
                Balance.text = Money.ToString();

                AmountOfSPace = AmountOfSPace - 1;
                SpaceAmount.text = AmountOfSPace.ToString();

                slot3.SetActive(true);
            }
            if (SpaceCounter == 4)
            {
                Money = Money - 10;
                Balance.text = Money.ToString();

                AmountOfSPace = AmountOfSPace - 1;
                SpaceAmount.text = AmountOfSPace.ToString();

                slot4.SetActive(true);
            }
        }
    }

    public void SpawnOneSpace()
    {
        GameObject NewSpawnSword = Instantiate(InventorySlot, BuyArea, Quaternion.identity);
        NewSpawnSword.transform.parent = ChestParent.transform;
    }

    public void Update()
{
        if(Money < 10)
        { InventorySlotButton.interactable = false; }

        if (Money > 10)
        { InventorySlotButton.interactable = true; }

        if (AmountOfArmor <= 0)
        {
            ArmorButton.interactable = false;
            //Debug.Log("OutofStock");
        }

        if (AmountOfArmor > 0)
        {
            ArmorButton.interactable = true;
            //Debug.Log("Back In Stock");
        }


        if (AmountOfSwords <= 0)
        {
            SwordButton.interactable = false;
        }

        if (AmountOfSwords > 0)
        {
            SwordButton.interactable = true;
        }


        if (AmountOfSheilds <= 0)
        {
            ShieldButton.interactable = false;
        }

        if (AmountOfSheilds > 0)
        {
            ShieldButton.interactable = true;
        }

        if (AmountOfPosition <= 0)
        {
            PotionButton.interactable = false;
        }
        if (AmountOfPosition > 0)
        {
            PotionButton.interactable = true;
        }

        if (AmountOfArrows <= 0)
        { ArrowButton.interactable = false; }

        if (AmountOfArrows > 0)
        { ArrowButton.interactable = true; }

        if(AmountOfDaggers <= 0)
        {DaggerButton.interactable = false; }

        if(AmountOfDaggers > 0)
        {  DaggerButton.interactable = true; }

        if(AmountOfOnePiece <= 0)
        { OnePieceButton.interactable = false; }

        if(AmountOfOnePiece > 0)
        {OnePieceButton.interactable = true; }
    }

    
}
