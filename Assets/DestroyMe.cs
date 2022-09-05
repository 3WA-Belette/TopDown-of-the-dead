using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMe : StateMachineBehaviour
{

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        GameObject.Destroy(animator.gameObject);
    }
}
