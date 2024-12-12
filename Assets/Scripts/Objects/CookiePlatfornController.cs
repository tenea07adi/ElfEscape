using UnityEngine;

public class CookiePlatfornController : MonoBehaviour
{

    [SerializeField]
    public AudioSource CrackSound;

    [SerializeField]
    private int BreakTime;

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
        TimerController.instance.AddAction(BreakTime, false, Destroy);
        CrackSound.Play();
    }

    private void Destroy()
    {
        Destroy(this.gameObject);
    }
}
