﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FreemiumCurrency : MonoBehaviour
{
    public int coin;
    public static FreemiumCurrency instance = null; 

   // public Text displayCurrency;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this; 
            DontDestroyOnLoad(instance);

        }else if (instance != null)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        coin = 20;
        //displayCurrency.text = "Coin: " + coin;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BasicCowboy()
    {
        coin = coin + 10;
        //displayCurrency.text = "Coin: " + coin;

    }

    public void RareCowboy()
    {
        coin = coin + 10;
        //displayCurrency.text = "Coin: " + coin;
    }

    public void BasicPosterCost()
    {
        coin = coin - 10;
        //displayCurrency.text = "Coin: " + coin;
    }
}
