using System.Collections.Generic;
using UnityEngine;

public class WorldStateController : MonoBehaviour
{
    [SerializeField]
    private List<BaseWorldStateStrategy> WorldStates;

    [SerializeField]
    private BaseWorldStateStrategy CurrentWorldStates;

    [SerializeField]
    private BaseWorldStateStrategy DefaultState;

    // Start is called before the first frame update
    void Start()
    {
        CurrentWorldStates.InitLogic();
    }

    // Update is called once per frame
    void Update()
    {
        RunStatesCycle();
    }

    private void RunStatesCycle()
    {
        if (CurrentWorldStates.ShouldExit())
        {
            CurrentWorldStates.ExitLogic();

            CurrentWorldStates = GetNextState();

            if (CurrentWorldStates == null)
            {
                CurrentWorldStates = DefaultState;
            }

            CurrentWorldStates.InitLogic();
        }

        CurrentWorldStates.MainLogic();
    }

    #nullable enable
    private BaseWorldStateStrategy? GetNextState()
    {
        foreach(var state in WorldStates)
        {
            if (state.ShouldEnter() && state != CurrentWorldStates)
            {
                return state;
            }
        }

        return null;
    }
}
