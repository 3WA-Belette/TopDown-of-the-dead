using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderLog : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

        Debug.Log("coucou");

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("coucou 2");
        
    }

}
