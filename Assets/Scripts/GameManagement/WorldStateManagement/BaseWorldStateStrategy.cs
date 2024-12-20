using UnityEngine;

public abstract class BaseWorldStateStrategy : MonoBehaviour, IWorldState
{
    public abstract bool ShouldEnter();
    public abstract bool ShouldExit();
    public abstract void InitLogic();
    public abstract void MainLogic();
    public abstract void ExitLogic();
}
