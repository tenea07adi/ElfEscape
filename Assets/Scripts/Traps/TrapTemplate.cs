using UnityEngine;

public abstract class TrapTemplate : MonoBehaviour
{
    [SerializeField]
    private int Damage;

    // Start is called before the first frame update
    void Start()
    {
        AdditionalStartLogic();
    }

    // Update is called once per frame
    void Update()
    {
        AdditionalUpdateLogic();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        var colHpObject = col.gameObject.GetComponent<IHpBehaviour>();

        if (colHpObject == null)
        {
            return;
        }

        colHpObject.Hp.DecreaseHp(Damage);

        Debug.Log("Damage");
    }

    protected abstract void AdditionalStartLogic();
    protected abstract void AdditionalUpdateLogic();
}
