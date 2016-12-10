using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    public float speed = 0.2f;
	// Update is called once per frame
	    void Update () {
            Debug.LogError("rotating!");
            this.transform.Rotate(new Vector3(0, 1, 0), speed);
	    }
}
