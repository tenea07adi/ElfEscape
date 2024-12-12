using UnityEngine;

public abstract class BasePausableGameObjectController : MonoBehaviour
{

    protected bool isPaused = false;

    protected bool lastStateIsPaused = true;

    protected RigidbodyConstraints2D lastRigidbodyConstraints2D;

    // Update is called once per frame
    void Update()
    {
        if (!isPaused)
        {
            UpdateLogic();

            if (lastStateIsPaused)
            {
                UnFreeze();
            }
        }
        else
        {
            if (!lastStateIsPaused)
            {
                Freeze();
            }
        }

        lastStateIsPaused = isPaused;
    }

    public bool IsPaused()
    {
        return isPaused;
    }

    public void TogglePause(bool state)
    {
        isPaused = state;
    }

    public void TogglePause()
    {
        isPaused = !isPaused;
    }

    protected abstract void UpdateLogic();

    protected void Freeze()
    {
        if (gameObject.GetComponent<Rigidbody2D>() != null)
        {
            lastRigidbodyConstraints2D = gameObject.GetComponent<Rigidbody2D>().constraints;
            gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
        }
    }

    protected void UnFreeze()
    {
        if (gameObject.GetComponent<Rigidbody2D>() != null)
        {
            gameObject.GetComponent<Rigidbody2D>().constraints = lastRigidbodyConstraints2D;
            gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
        }
    }
}
