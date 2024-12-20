using UnityEngine;

public class FallingIceSpikeTrapActivatorController : MonoBehaviour
{
    [SerializeField]
    private FallingIceSpikeTrapController Trap;

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
        var colHpObject = col.gameObject.GetComponent<IHpBehaviour>();

        if (colHpObject == null)
        {
            return;
        }

        Trap.ActivateTrap();
    }
}
