using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleDrive: MonoBehaviour
{
	//various variables
	public float speed;
	public float turn;
	private float horizontalInput;
	private float forwardInput;
	
    // Start is called before the first frame update
    void Start()
    {
        /*Nothing here yet ;)
	Depending on what we do for the handling model, there may be some code here, so we're leaving this untouched for now.*/
	
    }

    // Update is called once per frame
    void Update()
    {
		//Get input from horizontal and vertical axis
		horizontalInput = Input.GetAxis("Horizontal");
		forwardInput = Input.GetAxis("Vertical");
		
        	//Drive and turn the car based from input gathered above
		transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
		transform.Rotate(Vector3.up, turn * horizontalInput * Time.deltaTime);
    }
}
