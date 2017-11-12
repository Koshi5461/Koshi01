using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PumpScript : MonoBehaviour {
    public int countPump = 0;
    public GameObject handAnim;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerExit(Collider other)
    {
        //if (handAnim.activeInHierarchy)
        //{
        //    handAnim.SetActive(false);
        //}

        if (other.transform.name == "palm")
        {
            countPump++;
            Debug.Log("PumpCount:"+countPump);
        }

    }
}
