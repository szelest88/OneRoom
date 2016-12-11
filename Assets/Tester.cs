using UnityEngine;
using System.Collections;

public class Tester : MonoBehaviour {

    public OrbEntity orbEntity;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown("f"))
        {
            var camPos = Camera.main.transform.position;

            orbEntity.Shoot(camPos - transform.position);
            //orbEntity.Shoot(new Vector3(0.0f, 1.0f, 0.0f));

        }
	}
}
