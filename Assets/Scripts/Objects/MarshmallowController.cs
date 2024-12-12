using UnityEngine;

public class MarshmallowController : MonoBehaviour
{
    [SerializeField]
    private AudioSource JumpAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        var colMovementObj = col.gameObject.GetComponent<IMovementBehaviour>();

        if (colMovementObj == null)
        {
            return;
        }

        JumpAudioSource.Play();
        colMovementObj.Movement.ForceJump();
    }
}
