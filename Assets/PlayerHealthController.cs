using UnityEngine;
using System.Collections;

public class PlayerHealthController : MonoBehaviour
{
    
    // Use this for initialization
    void Start()
    {

    }

    float life = 1.0f;
    float damageAsFraction = 0.05f;

    public RectTransform healthBar;

    void OnCollisionEnter(Collision collision)
    {
        //if (collision.gameObject.layer == 14) // 14 is enemyBullet in layers list...
        {
            life -= damageAsFraction;
            
            //dfsfs
            Debug.LogError("SHOT!");
            healthBar.sizeDelta = new Vector2(life, 0.42f);
        }
    }

}