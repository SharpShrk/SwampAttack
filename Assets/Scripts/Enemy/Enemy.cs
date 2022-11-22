using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class Enemy : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private int _reward;

    protected Player TargetPlayer;

    public Player Target => TargetPlayer;
    public int Reward => _reward;

    public event UnityAction<Enemy> Dying;

    public void Init(Player target)
    {
        TargetPlayer = target;
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;

        if (_health <= 0)
        {
            Dying?.Invoke(this);
            Destroy(gameObject);
        }
    }
}