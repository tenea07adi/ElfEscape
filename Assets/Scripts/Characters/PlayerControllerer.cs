
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
        this.movementLogic.Move(UserInput.ReadAxisMovement());
        this.movementLogic.DoAnimationLogic(UserInput.ReadAxisMovement());
    }

    protected override void JumpLogic()
    {
        this.movementLogic.Jump(UserInput.ReadJump());
    }
}
