using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LogState : StateMachineBehaviour
{
    [SerializeField] string _stateText;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        StateLogger sl = animator.GetComponent<StateLogger>();
        sl.SetState(_stateText);

        Debug.Log($"OH JE SUIS EN TRAIN DE JOUER LE STATE {stateInfo.fullPathHash}");
        GameObject.FindObjectOfType<TextMeshProUGUI>().text = _stateText;
    }

}
