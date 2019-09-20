using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Cowboy : MonoBehaviour
{
    // Start is called before the first frame update

    private GameObject CurrencyManager; 
    
    void Start()
    {
        CurrencyManager = GameObject.Find("CurrencyManager");
        StartCoroutine(GoodbyeCowboy(Random.Range(5, 10)));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GoodbyeCowboy(float time)
    {
        yield return new WaitForSeconds(time);
        print("Goodbye");
        CurrencyManager.GetComponent<FreemiumCurrency>().BasicCowboy();
        Destroy(gameObject);
        
    }
}
