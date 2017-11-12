using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPracticeScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other) {
        SceneManager.LoadScene(2);
    }
}
