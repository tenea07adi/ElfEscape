using UnityEngine;

public class FallingIceSpiceTrapActivatorController : MonoBehaviour
{
    [SerializeField]
    private FallingIceSpiceTrapController Trap;

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
        Trap.ActivateTrap();
    }
}
