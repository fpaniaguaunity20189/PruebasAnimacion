using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopulationScript : MonoBehaviour {
    public GameObject[] prefabs;
    public int[] numItems;
	void Start () {
        float x, z;
        float ancho = transform.localScale.x*10/2;
        float largo = transform.localScale.z*10/2;
        for (int i = 0; i < prefabs.Length; i++) {
            for (int j=0; j < numItems[i]; j++) {
                x = Random.Range(-ancho, ancho);
                z = Random.Range(-largo, largo);
                Instantiate(prefabs[i], new Vector3(x, 0, z), Quaternion.identity);
            }
        }
    }
}
