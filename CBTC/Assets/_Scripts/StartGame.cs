using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    GameManager gm;

    void Start()
    {
        gm = GameManager.GetInstance();
        Debug.Log("startscript");
    }

    public void ClickStart()
    {
        gm.ChangeState(GameManager.GameState.GAME);
        Debug.Log("start");
    }

    public void ClickQuit()
    {
        Debug.Log("fechou");
    }
}
