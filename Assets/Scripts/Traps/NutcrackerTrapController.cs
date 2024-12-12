using UnityEngine;

public class NutcrackerTrapController : TrapTemplate
{
    [SerializeField]
    private AudioSource MovementSound;

    [SerializeField]
    private AudioSource HitSound;

    [SerializeField]
    private float MaxYPosition;

    private float MinYPosition;

    private bool CurrentDirectionUp = true;

    [field: SerializeField]
    public MovementMechanics Movement { get; private set; }

    protected override void AdditionalStartLogic()
    {
        MinYPosition = gameObject.transform.localPosition.y;
    }

    protected override void AdditionalUpdateLogic()
    {
        if(CurrentDirectionUp)
        {
            MoveUp();
        }
        else
        {
            MoveDown();
        }
    }

    private void MoveUp()
    {
        if (gameObject.transform.localPosition.y >= MaxYPosition)
        {
            CurrentDirectionUp = false;
        }
        else
        {
            Movement.MoveY(1);
        }
    }

    private void MoveDown()
    {
        if (gameObject.transform.localPosition.y <= MinYPosition)
        {
            CurrentDirectionUp = true;
            HitSound.Play();
        }
        else
        {
            Movement.MoveY(-1);
        }
    }
}
