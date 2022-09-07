using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicEvent : MonoBehaviour
{
    [SerializeField] List<Ennemy> _ennemies;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var enemy = collision.attachedRigidbody.GetComponent<Ennemy>();
        if(enemy != null)
        {
            if(_ennemies.Contains(enemy))
            {
                // rien
            }
            else
            {
                _ennemies.Add(enemy);
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        var enemy = collision.attachedRigidbody.GetComponent<Ennemy>();
        if (enemy != null)
        {
            if(_ennemies.Contains(enemy))
            {
                _ennemies.Remove(enemy);
            }
        }
    }


}
