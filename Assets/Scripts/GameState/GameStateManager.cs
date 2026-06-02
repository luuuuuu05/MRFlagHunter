using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public static GameStateManager Instance;

    [Header("当前游戏状态")]
    public GameState CurrentState = GameState.Waiting;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ChangeState(GameState newState)
    {
        CurrentState = newState;

        Debug.Log($"游戏状态切换 -> {newState}");

        switch (newState)
        {
            case GameState.Waiting:
                OnWaiting();
                break;

            case GameState.Countdown:
                OnCountdown();
                break;

            case GameState.Playing:
                OnPlaying();
                break;

            case GameState.Ended:
                OnEnded();
                break;
        }
    }

    private void OnWaiting()
    {
        Debug.Log("等待玩家加入...");
    }

    private void OnCountdown()
    {
        Debug.Log("开始倒计时...");
    }

    private void OnPlaying()
    {
        Debug.Log("游戏开始！");
    }

    private void OnEnded()
    {
        Debug.Log("游戏结束！");
    }
}