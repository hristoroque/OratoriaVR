using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GameState
{
    OnMenu,
    OnPause,
    OnPlay,
};

public class GameManager : MonoBehaviour
{
    public GameState state;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Pause()
    {
        Time.timeScale = 0;
        state = GameState.OnPause;
    }
}
