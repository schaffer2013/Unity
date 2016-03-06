using UnityEngine;
using System.Collections;

public class Player : Entity {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) 
		{
			GetComponent<Rigidbody2D>().transform.position += Vector3.up * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.DownArrow)) 
		{
			GetComponent<Rigidbody2D>().transform.position += Vector3.down * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.RightArrow)) 
		{
			GetComponent<Rigidbody2D>().transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) 
		{
			GetComponent<Rigidbody2D>().transform.position += Vector3.left * speed * Time.deltaTime;
		}
	}
}
