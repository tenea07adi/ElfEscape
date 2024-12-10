using UnityEngine;

public abstract class CharacterTemplate : MonoBehaviour
{
    [SerializeField]
    protected MovementMechanics movementLogic;

    // Start is called before the first frame update
    void Start()
    {
        AdditionalStartLogic();
    }

    // Update is called once per frame
    void Update()
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
