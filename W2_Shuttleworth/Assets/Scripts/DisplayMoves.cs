using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayMoves : MonoBehaviour
{
   // private GameObject TurnText;
   public GameObject textDisplay; 
    public int turnAmount= 10; 
    
    // Start is called before the first frame update
    void Start()
    {
       // null reference???? gameobject should be the object it's attached to? '
       // gameObject.GetComponent<TextMeshPro>().text = turnAmount.ToString();
       gameObject.GetComponent<TextMeshProUGUI>().text = turnAmount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateText()
    {
        //gameObject.GetComponent<TextMeshPro>().text = turnAmount.ToString(); 
        gameObject.GetComponent<TextMeshProUGUI>().text = turnAmount.ToString();
    }
    
    public void TurnDecrease()
    {
        turnAmount--;
        UpdateText();
    }
}
