using UnityEngine;

public class OrbEntity : MonoBehaviour {

    public GameObject laserBeamPrefab;

    public void Shoot(Vector3 direction)
    {
        var laserBeamObject = (GameObject)Instantiate(laserBeamPrefab, transform.position, transform.rotation);
        laserBeamObject.GetComponent<LaserBeamEntity>().Go(direction);
    }

}
