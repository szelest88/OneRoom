using UnityEngine;
using System.Collections;

public class BulletEntity : MonoBehaviour {

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }

}
