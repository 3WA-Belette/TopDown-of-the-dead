using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Pancarte : MonoBehaviour
{
    [Header("UI")]
    [SerializeField] Transform _canvas;
    [SerializeField] TextMeshProUGUI _renderText;
    [Header("Input")]
    [SerializeField] InputActionReference _confirmationInput;
    [Header("Conf")]
    [SerializeField, Multiline] string _text;

    [SerializeField] UnityEvent _onPancarteCut;

    public event UnityAction OnPancarteStop;

    public void LaunchPancarte()
    {
        // On gère l'UI
        _canvas.gameObject.SetActive(true);
        _renderText.text = _text;

        // On gère les inputs
        _confirmationInput.action.actionMap.Enable();
        _confirmationInput.action.started += WaitForInput;
    }

    void WaitForInput(InputAction.CallbackContext obj)
    {
        // UI
        _canvas.gameObject.SetActive(false);
        _renderText.text = "";

        // Input
        _confirmationInput.asset.Disable();
        _confirmationInput.action.started -= WaitForInput;

        // Event C#
        OnPancarteStop?.Invoke();
    }
}
