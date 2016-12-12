using UnityEngine;
using System.Collections;

public class OrbShootingBehaviour : MonoBehaviour
{
    public float shootingIntervalInSeconds = 1.0f;

    private OrbEntity orbEntity;
    private GameObject player;

    void Awake()
    {
        orbEntity = GetComponent<OrbEntity>();
        player = GameObject.Find("[CameraRig]/Camera (head)");
    }

    int i;
    private void FixedUpdate()
    {
        i++;

        if (i % 400 == 0)
        {
            Debug.Log("Shoot");
            orbEntity.Shoot(player.transform.position - this.transform.position);
        }
    }
}
