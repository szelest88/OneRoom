using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OrbManager : MonoBehaviour {
    private int orbCount = 0;
	// Use this for initialization
	void Awake () {
        orbCount = transform.childCount;

	}
	public void removeOneOrb()
    {
        orbCount--;
        Debug.LogError("ORB DELETED, ORB COUNT = " + orbCount);
        if(orbCount == 0)
        {
            GlobalData.didWon = true;
            Debug.LogError("DEAD, but WON!");
            SceneManager.LoadScene("deathScene");
        }
    }

}
