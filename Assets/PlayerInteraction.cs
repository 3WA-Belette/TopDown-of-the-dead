using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] InputActionReference _interactionInput;

    Pancarte _currentFocus;

    void Start()
    {
        _interactionInput.action.started += LaunchInteraction;
    }

    void LaunchInteraction(InputAction.CallbackContext obj)
    {
        if(_currentFocus != null)
        {
            _interactionInput.action.actionMap.Disable();
            _currentFocus.OnPancarteStop += ResumeGame;
            _currentFocus.LaunchPancarte();
        }
    }

    void ResumeGame()
    {
        _interactionInput.asset.Enable();
        _currentFocus.OnPancarteStop -= ResumeGame;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Pancarte>(out var p))
        {
            _currentFocus = p;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Pancarte>(out var p) && p == _currentFocus)
        {
            _currentFocus = null;
        }
    }

}
