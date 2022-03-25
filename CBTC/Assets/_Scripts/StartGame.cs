using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    GameManager gm;

    void Start()
    {
        gm = GameManager.GetInstance();
    }

    public void ClickStart()
    {
        gm.ChangeState(GameManager.GameState.GAME);
    }

    public void ClickQuit()
    {
        Application.Quit();
    }
}
