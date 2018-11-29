using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemyBlendScript : MonoBehaviour {
    Animator miAnimator;
    float corriendo = 0.1f;
    private void Start() {
        miAnimator = GetComponent<Animator>();
    }
    void Update () {
        if (Input.GetKey(KeyCode.UpArrow) && !Input.GetKey(KeyCode.LeftShift)) {
            //Anda (si está corriendo decrece la velocidad)
            corriendo = corriendo - 0.01f;
            corriendo = Mathf.Max(0.11f, corriendo);
            miAnimator.SetFloat("Corriendo", corriendo);
        } else if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftShift)) {
            //¡Corre Engendro, corre!
            corriendo = corriendo + 0.01f;
            corriendo = Mathf.Min(1, corriendo);
            miAnimator.SetFloat("Corriendo", corriendo);
        } else if (!Input.GetKey(KeyCode.UpArrow)) {
            //Se para despacito
            corriendo = corriendo - 0.01f;
            corriendo = Mathf.Max(0f, corriendo);
            miAnimator.SetFloat("Corriendo", corriendo);
        }

        if (corriendo > 0.1f) {
            transform.Rotate(0, Input.GetAxis("Horizontal"), 0);
        }
	}
}
