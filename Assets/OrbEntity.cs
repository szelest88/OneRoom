﻿using System;
using UnityEngine;

public class OrbEntity : MonoBehaviour
{
    public GameObject laserBeamPrefab;
    public GameObject shieldObject;
    public BarEntity healthBar;
    public BarEntity shieldBar;

    public int maxShield = 100;
    public int maxHealth = 100;
    private int shield;
    private int health;
    public OrbManager orbManager;

    private void Start()
    {
        shield = maxHealth;
        health = maxHealth;
        orbManager = transform.parent.GetComponent<OrbManager>();
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
            if (shield > 0)
            {
                shield = Math.Max(0, shield - damage.amount);
            }
            else if (health > 0)
            {
                health = Math.Max(0, health - damage.amount);
            }

            Debug.LogFormat("Damage: {0}, health: {1}, shield: {2}", damage.amount, health, shield);

            if (shield == 0)
            {
                shieldObject.SetActive(false);
            }

            if (health == 0)
            {
                orbManager.removeOneOrb();
                Destroy(gameObject);
            }
        }
    }
}
