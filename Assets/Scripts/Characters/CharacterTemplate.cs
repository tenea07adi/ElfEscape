using UnityEngine;

public abstract class CharacterTemplate : BasePausableGameObjectController, IMovementBehaviour, IHpBehaviour
{
    [field: SerializeField]
    public MovementMechanics Movement { get; private set; }

    [field: SerializeField]
    public HpMechanics Hp { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        AdditionalStartLogic();
    }

    protected override void UpdateLogic()
    {
        MovementLogic();
        JumpLogic();

        AdditionalUpdateLogic();
    }

    public Vector3 GetCurrentPosition()
    {
        return this.transform.position;
    }

    protected abstract void AdditionalStartLogic();
    protected abstract void AdditionalUpdateLogic();

    protected abstract void MovementLogic();
    protected abstract void JumpLogic();
}
