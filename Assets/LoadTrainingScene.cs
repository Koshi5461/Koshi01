using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTrainingScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        //StartCoroutine(LoadSceneTime());

    }

    void OnTriggerExit(Collider other) {
        SceneManager.LoadScene(1);
    }

    //IEnumerator LoadSceneTime()
    //{
    //    this.transform.localPosition = this.transform.localPosition + new Vector3(0, 0, 0.1f);
    //    yield return new WaitForSeconds(0.2f);
    //    this.transform.localPosition = this.transform.localPosition + new Vector3(0, 0, 0.1f);
    //    yield return new WaitForSeconds(0.2f);
    //    this.transform.localPosition = this.transform.localPosition + new Vector3(0, 0, 0.1f);
    //    yield return new WaitForSeconds(0.2f);
    //    this.transform.localPosition = this.transform.localPosition + new Vector3(0, 0, 0.1f);
    //    yield return new WaitForSeconds(0.2f);
    //    this.transform.localPosition = this.transform.localPosition + new Vector3(0, 0, -0.1f);
    //    yield return new WaitForSeconds(0.2f);
    //    this.transform.localPosition = this.transform.localPosition + new Vector3(0, 0, -0.1f);
    //    yield return new WaitForSeconds(0.2f);
    //    this.transform.localPosition = this.transform.localPosition + new Vector3(0, 0, -0.1f);
    //    yield return new WaitForSeconds(0.2f);
    //    this.transform.localPosition = this.transform.localPosition + new Vector3(0, 0, -0.1f);
    //    yield return new WaitForSeconds(0.2f);

    //}
}
