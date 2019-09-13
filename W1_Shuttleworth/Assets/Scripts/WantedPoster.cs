using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WantedPoster : MonoBehaviour
{

     GameObject wantedPoster;
    public GameObject posterPrompt, CurrencyManager;
    
    public List<GameObject> Cowboys;
    private Vector3 cowboyLocation;
    private float groundLeft, groundRight;
    
    // Start is called before the first frame update
    void Start()
    {
       CurrencyManager = GameObject.Find("CurrencyManager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (wantedPoster == null)
        {
            posterPrompt.SetActive(true);
        }

    }

    public void WantedPosterOn()
    {
        if (CurrencyManager.GetComponent<FreemiumCurrency>().coin >= 10)
        {
            if (wantedPoster == null)
            {
                wantedPoster = Instantiate(Resources.Load("Prefabs/WantedPoster")) as GameObject;
                CurrencyManager.GetComponent<FreemiumCurrency>().BasicPosterCost();
            }
        }

        //start coroutine for how long the poster runs and will stay up.
        StartCoroutine(PosterDecay(5f));
    }

    public void turnOffPrompt()
    {
        posterPrompt.SetActive(false);
    }

    IEnumerator PosterDecay(float time)
    {
        //Vector3 cowboyLocation = new Vector3(Random.Range(0,30),0,Random.Range(-1,5));
        for (int i=0; i<=10; i += Random.Range(1,3))
        {
            Vector3 cowboyLocation = new Vector3(Random.Range(-6,8),0,Random.Range(-5,3));
            Cowboys.Add(Instantiate(Resources.Load("Prefabs/Cowboy"),cowboyLocation, Quaternion.identity) as GameObject);
            
        }  
        yield return new WaitForSeconds(time);
        Destroy(wantedPoster);
    }


        
}
