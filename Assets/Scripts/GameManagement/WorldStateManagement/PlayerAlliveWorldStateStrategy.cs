
public class PlayerAlliveWorldStateStrategy : BaseWorldStateStrategy
{
    public override bool ShouldEnter()
    {
        return false;
    }

    public override bool ShouldExit()
    {
        return true;
    }

    public override void InitLogic()
    {
    }

    public override void MainLogic()
    {
    }

    public override void ExitLogic()
    {
    }
}
