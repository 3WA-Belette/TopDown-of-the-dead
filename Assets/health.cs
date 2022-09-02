using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour
{
    // ENNEMY
    int _hp;

    public void Damage(int amount)
    {
        _hp = _hp - amount;
    }

    // JOUEUR
    private void OnTriggerEnter2D(Collider2D collision)
    {

        var h = collision.attachedRigidbody.GetComponent<health>();
        if( h != null)
        {
            h.Damage(10);
        }
    }
}
