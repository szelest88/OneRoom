using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

    static bool stop = true;
    public Vector3 moveVector;
	// Use this for initialization
	void Start () {
        if(!stop)
        GetComponent<Rigidbody>().velocity = moveVector;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
