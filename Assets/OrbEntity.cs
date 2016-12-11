using UnityEngine;

public class OrbEntity : MonoBehaviour {
    GameObject player;
    public GameObject laserBeamPrefab;
    void Awake()
    {
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
        if (count % 40 == 0)
        {
            if (player != null)
            { 
            Shoot(player.transform.position);
                Debug.LogError("JEB!");
            }
        }
    }
}
