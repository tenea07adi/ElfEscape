using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager _instance;
    // Start is called before the first frame update
    void Start()
    {
        _instance = this;
    }

    // Update is called once per frame
    void Update()
    {
    }
}
