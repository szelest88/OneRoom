using UnityEngine;
using System.Collections;

public class PedestalEntity : MonoBehaviour {

    public SteamVR_PlayArea playArea;

    void Start () {
        var vertices = playArea.vertices;

        float minX = 0;
        float maxX = 0;
        float minZ = 0;
        float maxZ = 0;
        foreach (var v in vertices)
        {
            minX = Mathf.Min(minX, v.x);
            maxX = Mathf.Max(maxX, v.x);
            minZ = Mathf.Min(minZ, v.z);
            maxZ = Mathf.Max(maxZ, v.z);
        }

        var dx = maxX - minX;
        var dz = maxZ - minZ;
        
        transform.localScale = new Vector3(dx, 25, dz);
	}
	
}
