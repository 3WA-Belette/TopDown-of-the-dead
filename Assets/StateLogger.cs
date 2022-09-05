using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StateLogger : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;

    internal void SetState(string stateText)
    {
        _text.text = stateText;
    }
}
