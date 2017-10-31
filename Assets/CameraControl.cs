using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
    public GameObject mgr;
    public float speed = 0.2f;

	// Use this for initialization
	void Start () {


    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.K)) {
            speed *= 2;
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            speed /= 2;
        }

        if (Input.GetKey(KeyCode.D)){
           // transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
            transform.position += transform.TransformDirection(Vector3.right) * (speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.TransformDirection(Vector3.left) * (speed * Time.deltaTime);
//            transform.position = new Vector3(transform.position.x - speed, transform.position.y, transform.position.z);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * (speed * Time.deltaTime);
            //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.TransformDirection(Vector3.back) * (speed * Time.deltaTime);
            //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += transform.TransformDirection(Vector3.up) * (speed * Time.deltaTime);
            //transform.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += transform.TransformDirection(Vector3.down) * (speed * Time.deltaTime);
            //transform.position = new Vector3(transform.position.x, transform.position.y - speed, transform.position.z);
        }

        transform.LookAt(new Vector3(mgr.GetComponent<Matrix>().size / 2, mgr.GetComponent<Matrix>().size / 2, mgr.GetComponent<Matrix>().size / 2));
    }
}
