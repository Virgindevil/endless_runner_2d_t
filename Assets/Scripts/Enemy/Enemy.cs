using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _damage = 10;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Player player))
        {
            player.GetDamage(_damage);
        }
        Die();
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }
}
