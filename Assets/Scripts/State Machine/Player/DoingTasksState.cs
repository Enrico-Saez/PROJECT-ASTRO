using UnityEngine;

public class DoingTasksState : IPlayerState
{
    public void Enter(PlayerController player)
    {
        
    }
    public IPlayerState Do(PlayerController player)
    {
        if (Input.GetKeyDown(player.InteractKey))
        {
            Debug.Log("Parando de fazer task");
            return player.FreeMovingState;
        }
        return player.DoingTasksState;
    }

    public void FixedDo(PlayerController player)
    {
        
    }

    public void Exit(PlayerController player)
    {
        
    }
}