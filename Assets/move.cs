using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

    public Vector3 moveVector;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().velocity = moveVector;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
