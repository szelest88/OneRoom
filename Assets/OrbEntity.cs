using System;
using UnityEngine;

public class OrbEntity : MonoBehaviour
{
    public GameObject laserBeamPrefab;
    public BarEntity healthBar;
    public BarEntity shieldBar;

    public int maxShield = 100;
    public int maxHealth = 100;
    private int shield;
    private int health;

    private void Start()
    {
        shield = maxHealth;
        health = maxHealth;
    }

    public void Shoot(Vector3 direction)
    {
        var laserBeamObject = (GameObject)Instantiate(laserBeamPrefab, transform.position, transform.rotation);
        laserBeamObject.GetComponent<LaserBeamEntity>().Go(direction);
    }

    private void Update()
    {
        healthBar.progress = (float)health / (float)maxHealth;
        shieldBar.progress = (float)shield / (float)maxShield;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Damage damage = collision.gameObject.GetComponent<Damage>();

        if (damage != null)
        {
            if (shield >= 0)
            {
                shield = Math.Max(0, shield - damage.amount);
            }
            else if (health >= 0)
            {
                health = Math.Max(0, health - damage.amount);
            }

            if (health == 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
