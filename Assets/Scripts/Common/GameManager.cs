using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour 
{

    public enum state { Battle }
    public state GameState { get; private set; }


    private static GameManager _instance;
    public static GameManager GetInstance()
    {          
        return _instance;
    }

    private static bool _initailize = false;
    public static bool Initialized()
    {
        if (false == _initailize)
        {
            SceneManager.LoadScene("MainGame");
            return false;
        }
        else
            return true;
    }


    void Awake()
    {
        _instance = this;
        DontDestroyOnLoad(this);        
        _initailize = true;
    }
  
    
    public void SetState(state state)
    {
        GameState = state;
    }
    

    
}
