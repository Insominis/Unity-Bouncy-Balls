using UnityEngine;
using System.Collections;

public class createBalls : MonoBehaviour {
    public Rigidbody sphere;

    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown (0)) //when mouse is clicked
        {
            var mousePos = Input.mousePosition; //gets position of mouse
            mousePos.z = 10; //10m away from the camera
            var camPos = Camera.main.ScreenToWorldPoint(mousePos); //moves main camera to position of mouse
            Instantiate(sphere.gameObject, camPos, Quaternion.identity); //Casts sphere to GameObject.
            //Instantiates rigidbody object sphere at objectPos. Still receive cast error.
        }
    }
}
