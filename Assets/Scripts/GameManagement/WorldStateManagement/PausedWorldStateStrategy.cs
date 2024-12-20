using UnityEngine;

public class PausedWorldStateStrategy : BaseWorldStateStrategy
{
    [SerializeField]
    GameObject PausePanel;

    public override bool ShouldEnter()
    {
        return UserInput.PauseToggle();
    }

    public override bool ShouldExit()
    {
        return UserInput.PauseToggle();
    }

    public override void InitLogic()
    {
        PausePanel.SetActive(true);
        BasePausableGameObjectController.TogglePausableGameObjects();
    }

    public override void MainLogic()
    {
    }

    public override void ExitLogic()
    {
        PausePanel.SetActive(false);
        BasePausableGameObjectController.TogglePausableGameObjects();
    }
}
