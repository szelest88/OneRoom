using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

    static bool stop = false;
    public float speed;
	// Use this for initialization
	void Start () {
        if(!stop)
        GetComponent<Rigidbody>().velocity = transform.rotation * Vector3.forward * speed;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
