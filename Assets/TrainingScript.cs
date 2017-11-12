using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainingScript : MonoBehaviour {


    string message = "Hello, we will be learning how to perform CPR today. Please touch this box to continue.";
    public GameObject triggerBox;
    private int countPump = 0;
    public GameObject pumpBox;

	// Use this for initialization
	void Start () {
        pumpBox.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Count:"+triggerBox.GetComponent<TriggerScript>().step);
        if(triggerBox.GetComponent<TriggerScript>().step == 1)
        {
            message = "Check the victim for unresponsiveness. \nIf the person is not responsive and not breathing or not breathing normally.\n " +
                "Call 911 and return to the victim. If possible bring the phone next to the person and place on speaker mode.\n " +
                "In most locations the emergency dispatcher can assist you with CPR instructions.\n";
        } else if (triggerBox.GetComponent<TriggerScript>().step == 2)
        {
            message = "If the victim is still not breathing normally, coughing or moving, begin chest compressions.\n" +
                "Push down in the center of the chest 2-2.4 inches 30 times.\n" +
                "Pump hard and fast at the rate of 100-120/minute, faster than once per second.";
            pumpBox.SetActive(true);

            if (pumpBox.GetComponent<PumpScript>().countPump >= 5)
            {
                message = "Good! Press this button to continue";
            }
        }

    }

}
