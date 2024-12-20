using UnityEngine;

public abstract class TrapTemplate : BasePausableGameObjectController
{
    [SerializeField]
    private int Damage;

    // Start is called before the first frame update
    void Start()
    {
        AdditionalStartLogic();
    }

    protected override void UpdateLogic()
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
    }

    protected abstract void AdditionalStartLogic();
    protected abstract void AdditionalUpdateLogic();
}
