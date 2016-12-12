using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OrbManager : MonoBehaviour {
    public static  int orbCount = 0;
	// Use this for initialization
	void Start () {
        orbCount = transform.childCount;

	}
	void deleteOneOrb()
    {
        orbCount--;
        if(orbCount == 0)
        {
            GlobalData.didWon = true;
            Debug.LogError("DEAD!");
            SceneManager.LoadScene("deathScene");
        }
    }

}
