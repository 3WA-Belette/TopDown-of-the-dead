using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseLog : MonoBehaviour
{

    [SerializeField] InputActionReference _mousePOs;
    private void FixedUpdate()
    {
        var log = _mousePOs.action.ReadValue<Vector2>();
        Debug.Log(log);


        _mousePOs.action.actionMap.Enable();
    }

}
