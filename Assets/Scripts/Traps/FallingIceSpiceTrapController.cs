using UnityEngine;

public class FallingIceSpiceTrapController : TrapTemplate
{
    [SerializeField]
    private GameObject TrapRecipient;

    [SerializeField]
    private Rigidbody2D Rigidbody;

    [SerializeField]
    private bool CanBeActivated;

    protected override void AdditionalStartLogic()
    {
        Rigidbody.gravityScale = 0;
    }

    protected override void AdditionalUpdateLogic()
    {
    }

    public void ActivateTrap()
    {
        if (CanBeActivated)
        {
            Rigidbody.gravityScale = 1;
            TimerController.instance.AddAction(5, false, DestroyTrapRecipient);

            CanBeActivated = false;
        }
    }

    private void DestroyTrapRecipient()
    {
        Destroy(TrapRecipient);
    }
}
