using AdaptiveAudio;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdaptiveAudioSceneManager : MonoBehaviour
{
    public GameState gameState;

    VerticalAudioManager AudioManager;

    void Start()
    {
        AudioManager = VerticalAudioManager.Instance;
        gameState = GameState.Intro;
    }

    void Update()
    {
        switch (gameState)
        {
            case GameState.Intro:
                break;
            case GameState.Idle:
                break;
            case GameState.LightCombat:
                break;
            case GameState.HardCombat:
                break;
            case GameState.Ending:
                break;
        }
    }

    public enum GameState
    {
        Intro, Idle, LightCombat, HardCombat, Ending
    }
}
