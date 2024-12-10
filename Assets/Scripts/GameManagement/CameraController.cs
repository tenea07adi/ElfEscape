using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private float yCharacterDiff = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FollowTheCharacter();
    }

    private void FollowTheCharacter()
    {
        Vector3 characterPoz = PlayerControllerer._instance.GetCurrentPosition();

        this.transform.position = new Vector3(characterPoz.x, characterPoz.y + yCharacterDiff, this.transform.position.z);
    }
}
