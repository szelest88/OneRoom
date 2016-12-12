using UnityEngine;
using System.Collections;

public class Tester : MonoBehaviour
{
    public ShieldEntity shieldEntity;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("f"))
        {
            var camPos = Camera.main.transform.position;

            //orbEntity.Shoot(camPos - transform.position);
            //orbEntity.Shoot(new Vector3(1.0f, 0.0f, 0.0f));
            Debug.Log("Triigger");
            shieldEntity.Trigger();

        }
    }
}
