
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
        this.Movement.MoveX(UserInputAdapter._instance.ReadAxisMovement());
        this.Movement.DoAnimationLogic(UserInputAdapter._instance.ReadAxisMovement());
    }

    protected override void JumpLogic()
    {
        this.Movement.Jump(UserInputAdapter._instance.ReadJump());
    }
}
