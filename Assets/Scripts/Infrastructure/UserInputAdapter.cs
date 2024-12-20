using UnityEngine;

public class UserInputAdapter : MonoBehaviour
{
    public static UserInputAdapter _instance;

    private float axisSimulation = 0;
    private bool jumpSimulation = false;
    private bool escapeSimulation = false;

    // Start is called before the first frame update
    void Start()
    {
        _instance = this;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void LateUpdate()
    {
        ResetSimulation();
    }

    public float ReadAxisMovement()
    {
        return axisSimulation != 0 ? axisSimulation : Input.GetAxis("Horizontal");
    }

    public bool ReadJump()
    {
        return Input.GetKeyDown(KeyCode.Space) || jumpSimulation;
    }

    public bool PauseToggle()
    {
        return Input.GetKeyDown(KeyCode.Escape) || escapeSimulation;
    }

    public void SimulateAxis(int value)
    {
        axisSimulation = value;
    }

    public void SimulateJump()
    {
        jumpSimulation = true;
    }

    public void SimulateEscape()
    {
        escapeSimulation = true;
    }

    private void ResetSimulation()
    {
        axisSimulation = 0;
        jumpSimulation = false;
        escapeSimulation = false;
    }
}
