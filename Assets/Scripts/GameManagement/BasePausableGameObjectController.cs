using UnityEngine;

public abstract class BasePausableGameObjectController : MonoBehaviour
{

    protected bool isPaused = false;

    protected bool lastStateIsPaused = false;

    protected RigidbodyConstraints2D lastRigidbodyConstraints2D;

    protected Vector2 lastRigidbodyBelocity;

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

    public static void TogglePausableGameObjects()
    {
        BasePausableGameObjectController[] pausableObjects = FindObjectsOfType(typeof(BasePausableGameObjectController)) as BasePausableGameObjectController[];

        foreach (var obj in pausableObjects)
        {
            obj.TogglePause();
        }
    }

    protected abstract void UpdateLogic();

    protected void Freeze()
    {
        var Rigidbody = gameObject.GetComponent<Rigidbody2D>();


        if (Rigidbody != null)
        {
            lastRigidbodyBelocity = Rigidbody.velocity;

            lastRigidbodyConstraints2D = Rigidbody.constraints;
            Rigidbody.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY | RigidbodyConstraints2D.FreezeRotation;
        }
    }

    protected void UnFreeze()
    {
        var Rigidbody = gameObject.GetComponent<Rigidbody2D>();

        if (Rigidbody != null)
        {
            Rigidbody.velocity = lastRigidbodyBelocity;

            Rigidbody.constraints = lastRigidbodyConstraints2D;
            //Rigidbody.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
    }
}
