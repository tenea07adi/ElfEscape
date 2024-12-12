
public class PlayerControllerer : CharacterTemplate
{
    public static PlayerControllerer _instance;

    protected override void AdditionalStartLogic()
    {
        _instance = this;
    }

    protected override void AdditionalUpdateLogic()
    {

    }

    protected override void MovementLogic()
    {
        this.Movement.MoveX(UserInput.ReadAxisMovement());
        this.Movement.DoAnimationLogic(UserInput.ReadAxisMovement());
    }

    protected override void JumpLogic()
    {
        this.Movement.Jump(UserInput.ReadJump());
    }
}
