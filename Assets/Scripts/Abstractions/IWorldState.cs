
public interface IWorldState
{
    public bool ShouldEnter();

    public bool ShouldExit();

    public void InitLogic();

    public void MainLogic();

    public void ExitLogic();
}
