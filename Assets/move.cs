using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

    static bool stop = false;
    public Vector3 direction;
	// Use this for initialization
	void Start () {
        if(!stop)
        GetComponent<Rigidbody>().velocity = direction;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
