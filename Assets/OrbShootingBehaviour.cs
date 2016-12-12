using UnityEngine;
using System.Collections;

public class OrbShootingBehaviour : MonoBehaviour
{
    public float shootingIntervalInSeconds = 1.0f;

    public OrbEntity orbEntity; // public for debug
    public GameObject player;

    void Awake()
    {
        orbEntity = GetComponent<OrbEntity>();

        if (player == null)
        {
            player = GameObject.Find("[CameraRig]/Camera (eye)");
        }
    }

    int i;
    private void FixedUpdate()
    {
        i++;

        if (i % 400 == 0)
        {
            orbEntity.Shoot(player.transform.position - this.transform.position);
        }
    }
}
