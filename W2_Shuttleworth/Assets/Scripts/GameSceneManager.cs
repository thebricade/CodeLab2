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
                SceneManager.LoadScene("DailySeedScene");
                break;
            case "Endgame":
                break;
        }
    }
}
