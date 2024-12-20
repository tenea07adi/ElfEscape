using UnityEngine;

public static class UserInput
{
    public static float ReadAxisMovement()
    {
        return Input.GetAxis("Horizontal");
    }

    public static bool ReadJump()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }

    public static bool PauseToggle()
    {
        return Input.GetKeyDown(KeyCode.Escape);
    }
}
