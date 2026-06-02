using UnityEngine;

public class GameStateTester : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            GameStateManager.Instance.ChangeState(
                GameState.Waiting);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            GameStateManager.Instance.ChangeState(
                GameState.Countdown);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            GameStateManager.Instance.ChangeState(
                GameState.Playing);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            GameStateManager.Instance.ChangeState(
                GameState.Ended);
        }
    }
}