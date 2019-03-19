using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddKey : MonoBehaviour
{

    public GameObject key;

    //add 1 to player key total and destroy key picked up
    void OnTriggerEnter()
    {
        KeyTotal.instance.keysHeld += 1;
        Destroy(key);
    }
}
