using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerHealthController : MonoBehaviour
{
    
    // Use this for initialization
    void Start()
    {
       
    }
    public bool deathScene;
    public float life = 1.0f;
    float damageAsFraction = 0.05f;

    public RectTransform healthBar;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 14) // 14 is enemyBullet in layers list...
        {
            life -= damageAsFraction;
            
            //dfsfs
             healthBar.sizeDelta = new Vector2(life, 0.42f);
            if (life < 0.01f)
            {
                Debug.LogError("DEAD!");
                SceneManager.LoadScene("deathScene");
            }

        }
    }

}