using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    [SerializeField] List<Transition> transitions;

    protected Player Target { get; private set; }
    protected EnemyDragon Dragon { get; private set; }

    public void Enter(Player target)
    {
        if(enabled == false)
        {
            Target = target;
            enabled = true;

            foreach(var transition in transitions)
            {
                transition.enabled = true;
                transition.Init(Target);
            }
        }
    }

    public State GetNextState()
    {
        foreach(var transition in transitions)
        {
            if (transition.NeedTransit)
                return transition.TargetState;
        }

        return null;
    }

    public void Exit()
    {
        if(enabled == true)
        {
            foreach (var transition in transitions)
                transition.enabled = false;

            enabled = false;
        }
    }
}
