using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

// TODO: Nice modular component!
public class CoinPicker : MonoBehaviour
{
    private float coin = 0;

    public TextMeshProUGUI textCoins;

    private void OnTriggerEnter(Collider other)
    {
        // I would do `if(other.GetComponent<Coin>() != null)` instead
        if (other.transform.tag == "Coin")
        {
            coin++;
            textCoins.text = coin.ToString();
            
            Destroy(other.gameObject);
        }
    }
}
