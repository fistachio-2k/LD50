using System;
using UnityEditor;
using UnityEngine;

public enum GameState
{
    Undefined,
    Init,
    Play,
    Pause,
    LevelTransition,
    Lose,
    Win,
    Exit
}
public static class GamePlayManager
{
    public static event Action<GameState> OnGameStateChange;
    
    private static GamePlayData _gameData;
    private static GameObject _human;
    private static GameObject _blackHole;
    
    public static void ChangeGameState(GameState state)
    {
        if (_gameData != null && _gameData.State == state)
        {
            return;
        }

        switch (state)
        {
            case GameState.Init:
                OnInit();
                break;
            case GameState.Play:
                OnPlay();
                break;
            case GameState.Pause:
                OnPause();
                break;
            case GameState.LevelTransition:
                OnLevelTransition();
                break;
            case GameState.Lose:
                OnLose();
                break;
            case GameState.Win:
                OnWin();
                break;
            case GameState.Exit:
                OnExit();
                break;
            default:
                throw new ArgumentOutOfRangeException(nameof(state), state, null);
        }
        OnGameStateChange?.Invoke(state);
    }

    static void OnInit()
    {
        _gameData = AssetDatabase.LoadAssetAtPath<GamePlayData>("Assets/ScriptableObjects/GameData.asset");
        if (_gameData == null)
        {
            Debug.LogError("Can't find GameData, please check path is correct.");
            return;
        }

        _gameData.State = GameState.Init;
    }
    
    static void OnPlay()
    {
        throw new NotImplementedException();
    }
    
    static void OnPause()
    {
        throw new NotImplementedException();
    }
    
    static void OnLevelTransition()
    {
        throw new NotImplementedException();
    }
    
    static void OnLose()
    {
        throw new NotImplementedException();
    }
    
    static void OnWin()
    {
        throw new NotImplementedException();
    }
    
    static void OnExit()
    {
        throw new NotImplementedException();
    }
}