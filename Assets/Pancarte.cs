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


    public event UnityAction OnPancarteStop;
    public void LaunchPancarte()
    {
        _canvas.gameObject.SetActive(true);
        _renderText.text = _text;

        _confirmationInput.asset.Enable();
        _confirmationInput.action.started += WaitForInput;
    }

    void WaitForInput(InputAction.CallbackContext obj)
    {
        _renderText.text = "";
        _confirmationInput.asset.Disable();
        _canvas.gameObject.SetActive(false);
        _confirmationInput.action.started -= WaitForInput;
        OnPancarteStop?.Invoke();
    }
}
