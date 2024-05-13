using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaling : MonoBehaviour
{
    
    void Start()
    {
        {
            Transform prefabTransform = GetComponent<Transform>();
            prefabTransform.localScale = Vector3.one;
        }
    }
}

    

