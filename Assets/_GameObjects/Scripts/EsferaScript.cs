using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EsferaScript : MonoBehaviour {
    public DoorScript ds;
    public void OpenDoor() {
        ds.StartOpenDoor();
    }
}
