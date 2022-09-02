using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{

    [SerializeField] InputActionReference _move;

    private void Start()
    {
        _move.action.started += StartMove;
        _move.action.canceled += UpdateMove;
        _move.action.performed += StopMove;

    }

    private void StopMove(InputAction.CallbackContext obj)
    {

    }

    private void UpdateMove(InputAction.CallbackContext obj)
    {

    }

    private void StartMove(InputAction.CallbackContext obj)
    {

    }
}
