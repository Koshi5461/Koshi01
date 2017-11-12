using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubjectScript : MonoBehaviour {
    public GameObject player;
    private Animator thisAnimator;
    public GameObject phone;
    public bool is911Called = false;
    public bool didHeGoThere = false;
    public GameObject instructionBox;
    public GameObject instructionBackground;
    public GameObject pumpBox;
    private string message = "";
    private bool screamAudioPlayed = false;
    private AudioSource thisAudioSource;
    public GameObject goThereBox;
    public GameObject compressionRateText;
    public GameObject cprImage;
    public GameObject background1;
    public GameObject continueButton;
    public AudioSource playerAudio;

    public AudioClip source1;

	// Use this for initialization
	void Start () {

        message = "Today you will be practicing performing CPR in real life scenarios. Look around and see if somebody needs your help.";
        playerAudio.clip = source1;
        playerAudio.Play();
        thisAnimator = this.gameObject.GetComponent<Animator>();
        phone.SetActive(false);
        instructionBox.transform.parent.gameObject.SetActive(false);
        thisAudioSource = this.gameObject.GetComponent<AudioSource>();
        goThereBox.SetActive(false);
        cprImage.SetActive(false);
    }

    // Update is called once per frame
    void Update () {
        {
            if (Vector3.Distance(this.gameObject.transform.position, player.transform.position) > 5.0f)
            {
                this.gameObject.transform.Translate(Vector3.forward * Time.deltaTime);
            }
            else
            {
                thisAnimator.SetFloat("walkdone", 1.0f);
            }
            if (thisAnimator.GetCurrentAnimatorStateInfo(0).IsName("fall") && !screamAudioPlayed)
            {
                thisAudioSource.time = 2.0f;
                thisAudioSource.Play();
                screamAudioPlayed = true;
            }
            if (thisAnimator.GetCurrentAnimatorStateInfo(0).IsName("laying") && !didHeGoThere)
            {
                goThereBox.SetActive(true);
                didHeGoThere = true;
            }
            if (thisAnimator.GetCurrentAnimatorStateInfo(0).IsName("laying") && !is911Called && didHeGoThere)
            {
                Debug.Log("Logged " + phone.GetComponent<PhoneTriggerScript>().isPhonePicked);
                phone.SetActive(true);
                is911Called = phone.GetComponent<PhoneTriggerScript>().isPhonePicked;
            }
            else
            {
                phone.SetActive(false);

                //instructionBackground.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
                //message = "Good, you remembered to call 911!";
                //instructionBox.GetComponent<TextMesh>().text = message;
                //instructionBox.transform.parent.gameObject.SetActive(true);
                instructionBox.transform.parent.gameObject.SetActive(false);
            }
            if (!is911Called && pumpBox.GetComponent<PumpScriptPractice>().countPump > 0)
            {
                instructionBackground.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
                message = "You forgot to call 911!";
                instructionBox.GetComponent<TextMesh>().text = message;
                instructionBox.transform.parent.gameObject.SetActive(true);
            }
            else if (is911Called && pumpBox.GetComponent<PumpScriptPractice>().countPump > 0)
            {
                cprImage.SetActive(true);
                continueButton.SetActive(true);
                compressionRateText.SetActive(true);
                //instructionBox.transform.parent.gameObject.SetActive(false);
                compressionRateText.GetComponent<TextMesh>().text = "Your Pump Rate=" + pumpBox.GetComponent<PumpScriptPractice>().countPump * 3.0f + "/18 seconds\n" +
                        "Recommended = 30 pumps / 18 sec";
                if (pumpBox.GetComponent<PumpScriptPractice>().countPump * 3.0f >= 30)
                    background1.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
                else
                    background1.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            }
        }
	}
}
