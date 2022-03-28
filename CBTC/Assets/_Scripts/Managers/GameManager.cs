using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public GameState GameState;

    public delegate void ChangeStateDelegate();
    public static ChangeStateDelegate changeStateDelegate;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        ChangeState(GameState.Start);
    }

    public void ChangeState(GameState newState)
    {
        Debug.Log(newState);
        GameState = newState;
        switch (newState)
        {
            case GameState.Start:
                break;
            case GameState.GenerateGrid:
                GridManager.Instance.GenerateGrid();
                break;
            case GameState.SpawnHeroes:
                UnitManager.Instance.SpawnHeroes();
                break;
            case GameState.SpawnEnemies:
                UnitManager.Instance.SpawnEnemies();
                break;
            case GameState.HeroesTurn:
                break;
            case GameState.EnemiesTurn:
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(newState), newState, null);
        }
    }
} 
public enum GameState
    {
        Start = 0,
        GenerateGrid = 1,
        SpawnHeroes = 2,
        SpawnEnemies = 3,
        HeroesTurn = 4,
        EnemiesTurn = 5
    }
