using UnityEngine;
using System.Collections;

public class GetBounds : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
    public SteamVR_PlayArea playArea;
    public string info;
	// Update is called once per frame
	void Update () {
        string s =  playArea.vertices.ToString();
        // vertices - mn x, max x, min z, max z

        info = s;
    }
}
