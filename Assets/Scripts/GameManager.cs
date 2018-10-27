using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Material extrusionMaterial;
    public float speed = 0.1f;
    private float extAmount = 0;
    private float direction = 1f;
    private float max = 0.5f;
    private float min = 0f;
	
	
	// Update is called once per frame
	void Update () {
        if (extAmount < min) {
            direction = 1;
        }
        if (extAmount > max) {
            direction = -1;
        }

        extAmount += speed * Time.deltaTime * direction;

        extrusionMaterial.SetFloat("_ExtAmount", extAmount);
        
	}
}
