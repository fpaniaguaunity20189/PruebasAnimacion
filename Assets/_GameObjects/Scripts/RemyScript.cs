using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemyScript : MonoBehaviour {
    private Animator miAnimator;

	void Start () {
        miAnimator = GetComponent<Animator>();
	}

	//Version bool
	void Update () {
        if (Input.GetKeyDown(KeyCode.W)) {
            miAnimator.SetBool("EstaAndando", true);
        } else if (Input.GetKeyDown(KeyCode.S)) {
            miAnimator.SetBool("EstaAndando", false);
        }
        if (Input.GetKeyDown(KeyCode.P)) {
            miAnimator.SetTrigger("Punch");
        }
	}
}
