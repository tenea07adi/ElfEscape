using UnityEngine;

public class EscapeVehicleController : MonoBehaviour
{
    public static EscapeVehicleController _instance;
    public bool PlayerEntered {  get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        PlayerEntered = false;

        _instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        var playerObject = col.gameObject.GetComponent<PlayerControllerer>();

        if (playerObject == null)
        {
            return;
        }

        PlayerEntered = true;
    }

}
