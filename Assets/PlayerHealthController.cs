using UnityEngine;
using System.Collections;

public class PlayerHealthController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }
    public UnityEngine.UI.Slider slider;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 14) // 14 is enemyBullet in layers list...
        {
            
            //dfsfs
            Debug.LogError("SHOT!");
            slider.value -= 0.1f;
        }
    }

}