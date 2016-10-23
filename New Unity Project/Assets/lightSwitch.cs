using UnityEngine;
using System.Collections;

public class lightSwitch : MonoBehaviour
{
    public Light ballLight;
    
    // Use this for initialization
    void Start()
    {
        ballLight.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown ("space"))
        {
            ballLight.enabled = !ballLight.enabled;
        } 
    }
}

