using UnityEngine;
using UnityEngine.UI;

public class ExtraItem : MonoBehaviour
{
    public Text Balance;
    public int Money;
    public Text AmountForItem;
    public int AmountOfItem;
    public int PriceOfItem;

    public GameObject Prefab;

    public Button Button;
    public void BuyItem()
    {
        if (Money >= PriceOfItem)
        {

            Money = Money - PriceOfItem;
            Balance.text = Money.ToString();

            AmountOfItem = AmountOfItem - 1;
            AmountForItem.text = AmountOfItem.ToString();

            SpawnItem();
        }
    }
    public GameObject Parent;
    public Vector3 BuyArea;
    public void SpawnItem()
    {
        GameObject NewSpawnSword = Instantiate(Prefab, BuyArea, Quaternion.identity);
        NewSpawnSword.transform.parent = Parent.transform;
    }
    public void Update()
    {
        if (AmountOfItem <= 0)
        {
            Button.interactable = false;
        }

        else if (AmountOfItem >= 1)
        {
            Button.interactable = true;
        }
    }

}
