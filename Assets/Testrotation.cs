using UnityEngine;
using System.Collections;

public class Testrotation : MonoBehaviour {

    public Vector3 dir;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (dir != Vector3.zero)
        {
        gameObject.transform.rotation = Quaternion.LookRotation(dir, Vector3.up);
        //gameObject.transform.rotation.SetLookRotation(dir.normalized, Vector3.up);

        } else
        {
            gameObject.transform.rotation = Quaternion.identity;
        }


	}
}
