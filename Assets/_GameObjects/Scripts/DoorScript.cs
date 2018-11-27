using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {
    float speed = 0.05f;
    float localXLimit = -5;
	public void StartOpenDoor() {
        StartCoroutine("OpenDoor");
    }

    IEnumerator OpenDoor() {
        while (transform.localPosition.x > localXLimit){
            yield return null;
            transform.Translate(Vector3.left * speed);
        }
    }
}
