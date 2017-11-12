using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubjectScript : MonoBehaviour {
    public GameObject player;
    private Animator thisAnimator;
    public GameObject phone;
    public bool is911Called = false;
    public GameObject instructionBox;
    public GameObject instructionBackground;
    public GameObject pumpBox;
    private string message = "";
    private bool screamAudioPlayed = false;
    private AudioSource thisAudioSource;

	// Use this for initialization
	void Start () {
        thisAnimator = this.gameObject.GetComponent<Animator>();
        phone.SetActive(false);
        instructionBox.transform.parent.gameObject.SetActive(false);
        thisAudioSource = this.gameObject.GetComponent<AudioSource>();
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
        if(thisAnimator.GetCurrentAnimatorStateInfo(0).IsName("fall") && !screamAudioPlayed)
        {
            thisAudioSource.time = 2.0f;
            thisAudioSource.Play();
            screamAudioPlayed = true;
        }
        if(thisAnimator.GetCurrentAnimatorStateInfo(0).IsName("laying") && !is911Called)
        {
            phone.SetActive(true);
            is911Called = phone.GetComponent<PhoneTriggerScript>().isPhonePicked;
        } else
        {
            phone.SetActive(false);
            instructionBox.transform.parent.gameObject.SetActive(false);
        }
        if(!is911Called && pumpBox.GetComponent<PumpScriptPractice>().countPump > 0)
        {
            instructionBackground.GetComponent<Material>().SetColor("_Color", Color.red);
            message = "You forgot to call 911!";
            instructionBox.GetComponent<TextMesh>().text = message;
            instructionBox.transform.parent.gameObject.SetActive(true);
        } else
        {
            instructionBox.transform.parent.gameObject.SetActive(false);
        }
	}
}
