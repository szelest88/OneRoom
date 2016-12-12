using UnityEngine;
using System.Collections;

public class DeathManager : MonoBehaviour {
    public GameObject endgame;
	// Use this for initialization
	void Start () {
        if (GlobalData.didWon)
        {
            TextMesh[] textMeshes = endgame.transform.GetComponentsInChildren<TextMesh>();
            foreach(TextMesh tm in textMeshes)
            {
                tm.fontSize = 160;
                tm.text = "You won!";
            }

            GameObject.Find("Camera (eye)").GetComponent<Camera>().backgroundColor = new Color(0f, 0.7f, 1);
        }

        GlobalData.didWon = false; // reset the state for the next game
	}
	
}
