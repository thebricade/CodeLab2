using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public enum GameScenes
{
    Mainmenu,
    GameLevel,
    EndGame
}

public class GameSceneManager : MonoBehaviour
{
    public static GameSceneManager instance = null;
    //public int turnAmount; 
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
  
    //change the game scenes 
    public void GameScenes(string scene)
    {
        switch (scene)
        {
            case "Mainmenu":
                break;
            case "GameLevel":
               // turnAmount = 10; 
                SceneManager.LoadScene("DailySeedScene");
                break;
            case "Endgame":
                break;
        }
    }


    
    //null error on text from main menu
}
