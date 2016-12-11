using UnityEngine;
using System.Collections;

public class ProtoEnemyController2 : MonoBehaviour {

    Material targetMaterial;
    void Awake()
    {
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

    public void Update()
    {
        if (Input.GetKeyDown("space"))
        {

        }
    }
    void dieBastard()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
       // transform.position = new Vector3(transform.position.x, 3-transform.position.y, transform.position.z);
        //Material targetMaterial = GetComponent<MeshRenderer>().material;
        //Color c = targetMaterial.color;
        
        //c.b -= 0.1f;
        //c.r -= 0.1f;
        //c.g -= 0.1f;
        //c.a -= 0.25f;
        //targetMaterial.color = c;
        foreach (MeshRenderer m in GetComponentsInChildren<MeshRenderer>())
        {
            Material targetMaterial = m.material;
            Color c = targetMaterial.color;
            c.a -= 1f;
            targetMaterial.color = c;
            m.material = targetMaterial;
        }
        GetComponent<SphereCollider>().radius = 0.28f;
        //StartCoroutine(colorBack());
        other.gameObject.GetComponent<MeshRenderer>().enabled = false;
    }
}
