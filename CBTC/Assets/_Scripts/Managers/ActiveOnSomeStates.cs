using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ActiveOnSomeStates : MonoBehaviour
{

    public GameState[] activeStates;

    void Start()
    {
        GameManager.changeStateDelegate += UpdateVisibility;
        UpdateVisibility();
    }

    void UpdateVisibility()
    {
        if (activeStates.Contains(GameManager.Instance.GameState))
        {
            gameObject.SetActive(true);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}