using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{

    public int step = 0;

    // Use this for initialization
    void Start()
    {

    }


    void OnTriggerExit(Collider other)
    {
        if (other.transform.name == "palm")
        {
            step = step + 1;
        }

    }
    void Update()
    {
    }

}
