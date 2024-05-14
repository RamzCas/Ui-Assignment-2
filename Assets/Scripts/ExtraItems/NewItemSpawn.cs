using UnityEngine;

public class NewItemSpawn : MonoBehaviour
{
    public GameObject Item5;
    public GameObject Item6;
    public GameObject Item7;

    public float MaxTime = 20f;
    public float Timer;
    private void Start()
    {
      
    }

    private void Update()
    {
        Timer += Time.deltaTime;

        if (Timer > MaxTime)
        {
            //Debug.Log("spawn");
            Item5.SetActive(true);
            Item6.SetActive(true);
            Item7.SetActive(true);

        }
    }
}
