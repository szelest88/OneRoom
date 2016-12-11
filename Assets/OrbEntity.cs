using System;
using UnityEngine;

public class OrbEntity : MonoBehaviour {
    GameObject player;
    public GameObject laserBeamPrefab;
    void Awake()
    {
        player = GameObject.Find("[CameraRig]/Camera (head)");
    }
    public void Shoot(Vector3 direction)
    {
        try
        {
            var laserBeamObject = (GameObject)Instantiate(laserBeamPrefab, transform.position, transform.rotation);
            laserBeamObject.GetComponent<LaserBeamEntity>().Go(direction);
        }catch(Exception e)
        {
            Debug.LogError("AA" + e.StackTrace);
        }
    }

    int count = 0;
    void FixedUpdate()
    {
        count++;
        if (count % 400 == 0)
        {
            if (player != null)
            { 
            Shoot(player.transform.position-this.transform.position);
                Debug.LogError("JEB!");
            }
        }
    }
}
