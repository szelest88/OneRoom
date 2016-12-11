using UnityEngine;
using System.Collections;

public class LaserBeamEntity : MonoBehaviour {

    private const float Force = 1f;

    public Rigidbody rigidBody;

    public void Go(Vector3 direction)
    {
        var dir = direction.normalized;

        rigidBody.AddForce(dir * Force, ForceMode.VelocityChange);
        rigidBody.rotation = Quaternion.LookRotation(dir, Vector3.up);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
    }

}
