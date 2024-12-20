using UnityEngine;

public class FallingIceSpikeTrapController : TrapTemplate
{
    [SerializeField]
    private GameObject TrapRecipient;

    [SerializeField]
    private Rigidbody2D Rigidbody;

    [SerializeField]
    private AudioSource IceCrackingSound;

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

            IceCrackingSound.Play();

            CanBeActivated = false;
        }
    }

    private void DestroyTrapRecipient()
    {
        Destroy(TrapRecipient);
    }
}
