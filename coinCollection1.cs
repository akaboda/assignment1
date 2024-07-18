using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCollection1 : MonoBehaviour
{
    public int value;

    

   void onTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
           
            Destroy(gameObject);
            coincounter.instance.IncreaseCoins(value);
        }
    }
}
