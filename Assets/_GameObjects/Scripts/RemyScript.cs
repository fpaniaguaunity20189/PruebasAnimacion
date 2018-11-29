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
        float y = Input.GetAxis("Vertical");
        miAnimator.SetFloat("Corriendo", y);
        if (Input.GetKeyDown(KeyCode.Space)) {
            miAnimator.SetBool("EstaAndando", true);
        } else if (Input.GetKeyDown(KeyCode.S)) {
            miAnimator.SetBool("EstaAndando", false);
        }
        if (Input.GetKeyDown(KeyCode.P)) {
            miAnimator.SetTrigger("Punch");
        }
        
	}

    public void ReproducirSonidoPisada() {
        print("SONIDO DE PISADA");
    }
}
