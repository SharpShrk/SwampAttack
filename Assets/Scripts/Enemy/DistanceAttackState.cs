using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class DistanceAttackState : State
{
    [SerializeField] private float _delay;

    private float _lastAttackTime;
    private Animator _animator;
    private EnemyDragon _dragon;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _dragon = GetComponent<EnemyDragon>();
    }

    private void Update()
    {
        if (_lastAttackTime <= 0)
        {
            Attack(Target);
            _lastAttackTime = _delay;
        }

        _lastAttackTime -= Time.deltaTime;
    }

    private void Attack(Player target)
    {
        _animator.Play("Attack");
        _dragon.Shoot();
    }
}
