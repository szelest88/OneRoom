using UnityEngine;
using System.Collections;

public class OrbitingBehaviour : MonoBehaviour {
    public float radius = 2;
    public Transform target;
    public float offset;
    public bool direction;
    Rigidbody rigidBody;
    //Vec
	// Use this for initialization
	void Start () {
        Debug.Log("start orbiting behvior");
        rigidBody = GetComponent<Rigidbody>();
        if ((transform.position - target.position).magnitude > radius)
        {
            Vector3 velocity =  (target.position - transform.position).normalized;
            //velocity.y = 0;
            //rigidBody.velocity = velocity*20;
         //   rigidBody.AddForce(velocity.normalized * 3,ForceMode.VelocityChange);
            
            Debug.Log("setting velocity to " + velocity);

        }
        else
        {
       //     rigidBody.velocity = new Vector3(0, 0, 0);

            Debug.Log("setting velocity to " + rigidBody.velocity);
        }

	}

    Vector3 calcDir(Vector3 pos, Vector3 target, float radius, float alpha)
    {
        Vector3 v = pos - target;

        Vector3 vr = v.normalized * radius;

        Vector3 vrPrim = Matrix4x4.TRS(new Vector3(0, 0, 0), Quaternion.Euler(0, alpha*180.0f/3.1415f, 0), new Vector3(1, 1, 1)).MultiplyPoint3x4(vr);
        Vector3 targetPoint = target + vrPrim;
        Vector3 direction = (targetPoint - pos).normalized;
        return direction;

    }
    int x = 0;
    float alpha = 0f;
    bool velocityNeeds0 = true;
    // Update is called once per frame
    void FixedUpdate() {
        x++;
        if (x % 10 == 0)
        {
            
            alpha = Mathf.Atan2(transform.position.x-target.position.z,transform.position.z-target.position.z);        
            // fix the movement vector
            rigidBody.AddForce(5*calcDir(transform.position,new Vector3(0,0,0),radius,alpha)); // addforce było nieźle...
        }
        if((transform.position - target.position).magnitude <= radius && velocityNeeds0)
        {
            rigidBody.velocity = new Vector3(0, 0, 0);

            velocityNeeds0 = false;
            Debug.Log("setting velocity to " + rigidBody.velocity);
        }

    }
}
