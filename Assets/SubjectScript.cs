using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubjectScript : MonoBehaviour {
    public GameObject player;
    private Animator thisAnimator;
    public GameObject phone;
    public bool is911Called = false;

	// Use this for initialization
	void Start () {
        thisAnimator = this.gameObject.GetComponent<Animator>();
        phone.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if(Vector3.Distance(this.gameObject.transform.position, player.transform.position) > 5.0f)
        {
            this.gameObject.transform.Translate(Vector3.forward * Time.deltaTime);
        } else
        {
            thisAnimator.SetFloat("walkdone", 1.0f);
        }
        if(thisAnimator.GetCurrentAnimatorStateInfo(0).IsName("laying") && !is911Called)
        {
            phone.SetActive(true);
            is911Called = phone.GetComponent<PhoneTriggerScript>().isPhonePicked;
        } else
        {
            phone.SetActive(false);
        }

	}
}
