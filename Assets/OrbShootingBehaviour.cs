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

    private IEnumerator Update()
    {
        orbEntity.Shoot(player.transform.position - this.transform.position);
        yield return new WaitForSeconds(shootingIntervalInSeconds);
    }
}
