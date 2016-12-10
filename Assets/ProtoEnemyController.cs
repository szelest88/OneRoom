using UnityEngine;
using System.Collections;

public class ProtoEnemyController : MonoBehaviour {

    Material targetMaterial;
    IEnumerator colorBack()
    {
        print(Time.time);


        yield return new WaitForSeconds(0.25f);
        Debug.LogError("colorBack");
        Material targetMaterial = GetComponent<MeshRenderer>().material;
        targetMaterial.SetColor("_Color", Color.white);
        print(Time.time);
    }
    void Update()
    {
        Debug.LogError("rotating!");
        this.transform.Rotate(new Vector3(0, 1, 0), 0.2f);
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
