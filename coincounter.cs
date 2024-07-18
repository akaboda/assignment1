using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coincounter : MonoBehaviour
{
    public static coincounter instance;
    public TMP_Text cointText;
    public int currectCoins = 0;

    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        cointText.text = "COINS: " + currectCoins.ToString();
    }

   public void IncreaseCoins(int v)
    {
        currectCoins += v;
        cointText.text = "COINS: " + currectCoins.ToString();
    }
}
