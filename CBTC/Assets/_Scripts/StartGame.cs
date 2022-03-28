using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    void Start()
    {

    }

    public void ClickStart()
    {
        GameManager.Instance.ChangeState(GameState.GenerateGrid);
        gameObject.SetActive(false);
    }

    public void ClickQuit()
    {
        Application.Quit();
    }
}
