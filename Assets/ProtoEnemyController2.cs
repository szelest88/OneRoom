using UnityEngine;
using System.Collections;

public class ProtoEnemyController2 : MonoBehaviour {

    Material targetMaterial;
    void Awake()
    {
        GetComponent<Rigidbody>().AddForce(10, 10, 0);
    }
    IEnumerator colorBack()
    {
        print(Time.time);


        yield return new WaitForSeconds(0.25f);
        Debug.LogError("colorBack");
        Material targetMaterial = GetComponent<MeshRenderer>().material;
        targetMaterial.SetColor("_Color", Color.white);
        print(Time.time);
    }

    private void OnTriggerEnter(Collider other)
    {
       // transform.position = new Vector3(transform.position.x, 3-transform.position.y, transform.position.z);
        Material targetMaterial = GetComponent<MeshRenderer>().material;
        targetMaterial.SetColor("_Color",Color.green);

        StartCoroutine(colorBack());
        other.gameObject.GetComponent<MeshRenderer>().enabled = false;
    }
}
