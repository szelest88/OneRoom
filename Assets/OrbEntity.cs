using System;
using UnityEngine;

public class OrbEntity : MonoBehaviour {
    public GameObject player;
    public GameObject laserBeamPrefab;
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("MainCamera");
    }
    public void Shoot(Vector3 direction)
    {
            var laserBeamObject = (GameObject)Instantiate(laserBeamPrefab, transform.position, transform.rotation);
            laserBeamObject.GetComponent<LaserBeamEntity>().Go(direction);
        
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
            }
        }
    }
}
