using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDragon : Enemy
{
    [SerializeField] private Transform _shootPoint;
    [SerializeField] private Blast _blast;

    public void Shoot()
    {
        Instantiate(_blast, _shootPoint.position, Quaternion.identity);
    }
}
