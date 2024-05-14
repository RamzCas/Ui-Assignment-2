using UnityEngine;


public class SellSword : MonoBehaviour
{
    //public Text Balance;
    //public int Money;
    //public Text SwordAmount;
    //public int AmountOfSwords;
    // Start is called before the first frame update

   // public Camera Camera;

    public GameObject SwordPrefab;
    public GameObject SheildPrefab;

    public Buy sell;
    
    void Start()
    {
       
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
       
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            //if (hit.collider != null)
            {
              if(hit.collider != null) 
                {
                    Debug.Log("hit");

                    if(hit.collider.CompareTag("Sword"))  
                    {
                        Debug.Log("sell Sword");
                        sell.RefundSword();
                        GameObject swordObject = hit.collider.gameObject;
                        Destroy(swordObject);
                    }

                    if (hit.collider.CompareTag("Sheild")) 
                    {
                        Debug.Log("sell Sheild");
                        sell.RefundSheild();
                        GameObject sheildObject = hit.collider.gameObject;
                        Destroy(sheildObject);
                    }

                    if (hit.collider.CompareTag("Potion"))
                    {
                        Debug.Log("sell Potion");
                        sell.RefundPotion();
                        GameObject PotionObject = hit.collider.gameObject;
                        Destroy(PotionObject);
                    }

                    if (hit.collider.CompareTag("Armour")) 
                    {
                        Debug.Log("sell Armour");
                        sell.RefundArmour();    
                        GameObject ArmourObject = hit.collider.gameObject;
                        Destroy(ArmourObject);
                    }
                }
               
               
            }
        }
    }
}
