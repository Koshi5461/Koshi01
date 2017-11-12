using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainingScript : MonoBehaviour {


    string message = "Hello, we will be learning how to perform CPR today.\nPlease touch button below to continue.";
    public GameObject triggerBox;
    private int countPump = 0;
    public GameObject pumpBox;
    public GameObject instructionBox;
    public GameObject cprImage;
    public GameObject handAnim;

    bool isHandAnimationShownOnce = false;
	// Use this for initialization
	void Start () {
        pumpBox.SetActive(false);
        cprImage.SetActive(false);
        handAnim.SetActive(false);

    }

    // Update is called once per frame
    void Update () {
        Debug.Log("Count:"+triggerBox.GetComponent<TriggerScript>().step);
        if(triggerBox.GetComponent<TriggerScript>().step == 1)
        {
            message = "Check the victim for unresponsiveness. \nIf the person is not responsive and \nnot breathing or not breathing normally.\n" +
                "Call 911 and return to the victim.\n If possible bring the phone next to the person\nand place on speaker mode.\n " +
                "In most locations the emergency dispatcher can\nassist you with CPR instructions.\n";
        } else if (triggerBox.GetComponent<TriggerScript>().step == 2)
        {
            cprImage.SetActive(true);
            message = "If the victim is still not breathing normally, coughing\n or moving, begin chest compressions.\n" +
                "Push down in the center of the chest as shown\n in the image 2-2.4 inches 30 times.\n" +
                "Pump hard and fast at the rate of\n 100-120/minute, faster than once per second.";
            pumpBox.SetActive(true);
            if (!isHandAnimationShownOnce && !handAnim.activeInHierarchy)
            {
                handAnim.SetActive(true);
                StartCoroutine(PlayHandAnimation());
            }
            if (pumpBox.GetComponent<PumpScript>().countPump >= 5)
            {
                cprImage.SetActive(false);
                message = "Good! Press this button to continue";
            }
        } else if (triggerBox.GetComponent<TriggerScript>().step > 2 && pumpBox.GetComponent<PumpScript>().countPump >= 5)
        {
            cprImage.SetActive(false);
            message = "Good! Press this button to continue";
        }
        instructionBox.GetComponent<TextMesh>().text = message;

    }


    public IEnumerator PlayHandAnimation()
    {
        yield return new WaitForSeconds(10);
        handAnim.SetActive(false);
        isHandAnimationShownOnce = true;
    }
}
