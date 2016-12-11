using UnityEngine;
using System.Collections;

public class ProtoEnemyController2 : MonoBehaviour {

    Material targetMaterial;

    public GameObject orbShield;
    void Awake()
    {
        orbShield = transform.FindChild("OrbShield").gameObject;
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
        gameObject.SetActive(false);
    }
    bool shieldRemoved = false;
    void removeShield()
    {
        shieldRemoved = true;
        orbShield.SetActive(false);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Damage>() != null) {
            if (!shieldRemoved)
            {
                removeShield();
            }
            else
            {
                dieBastard();
            }
    }
    }
}
