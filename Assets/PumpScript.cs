using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpScript : MonoBehaviour {
    public int countPump = 0;
    public GameObject handAnim;
    public float time = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (countPump >= 1)
        {
            time += Time.deltaTime;
            Debug.Log("Time="+time);
        }
    }

    void OnTriggerExit(Collider other)
    {

        if (other.transform.name == "palm")
        {
            countPump++;
            Debug.Log("PumpCount:"+countPump);
        }

    }
}
