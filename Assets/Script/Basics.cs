using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basics : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string myName = "DENIS";
        Debug.Log(myName.Substring(myName.Length - 2,2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
