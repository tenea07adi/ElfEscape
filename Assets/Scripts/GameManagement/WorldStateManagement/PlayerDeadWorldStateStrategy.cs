using UnityEngine;

public class PlayerDeadWorldStateStrategy : BaseWorldStateStrategy
{
    [SerializeField]
    GameObject PlayerDeadPanel;

    public override bool ShouldEnter()
    {
        return !PlayerControllerer._instance.Hp.IsAllive;
    }

    public override bool ShouldExit()
    {
        return PlayerControllerer._instance.Hp.IsAllive;
    }

    public override void InitLogic()
    {
        PlayerDeadPanel.SetActive(true);
        BasePausableGameObjectController.TogglePausableGameObjects();
    }

    public override void MainLogic()
    {
    }

    public override void ExitLogic()
    {
        PlayerDeadPanel.SetActive(true);
        BasePausableGameObjectController.TogglePausableGameObjects();
    }
}
