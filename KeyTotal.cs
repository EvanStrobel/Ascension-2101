using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyTotal : MonoBehaviour
{
    public static KeyTotal instance;
    public int keysHeld;
    
    //initialize the number of keys
    void Start()
    {
        instance = this;
        keysHeld = 0;
    }
}
