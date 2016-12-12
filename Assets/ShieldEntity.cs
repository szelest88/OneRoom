using UnityEngine;
using System;
using System.Collections;

public enum ShieldState
{
    ENABLED,
    DISABLED,
    REGENERATING,
}

public class ShieldEntity : MonoBehaviour
{
    public GameObject shieldObject;
    public GameObject shieldColliderObject;
    public BarEntity shieldEnergyBar;

    public int shieldMaxEnergy = 100;
    public int shieldRegenerationSpeedPerSecond = 100;

    private ShieldState shieldState;
    private bool trigger;
    private int shieldEnergy;
    private float shieldEnergyFloat;
    private bool shieldRegenerating;

    public void Trigger()
    {
        trigger = true;
    }

    private void Start()
    {
        shieldState = ShieldState.DISABLED;
        shieldEnergy = shieldMaxEnergy;
        shieldEnergyFloat = shieldEnergy;
        shieldObject.SetActive(shieldState == ShieldState.ENABLED);
        shieldColliderObject.SetActive(shieldState == ShieldState.ENABLED);
    }

    private void Update()
    {
        switch (shieldState)
        {
            case ShieldState.DISABLED:
                if (trigger)
                {
                    shieldState = ShieldState.ENABLED;
                }
                break;

            case ShieldState.ENABLED:
                if (shieldEnergy == 0)
                {
                    shieldState = ShieldState.REGENERATING;
                }
                else if (!trigger)
                {
                    shieldState = ShieldState.DISABLED;
                }
                break;

            case ShieldState.REGENERATING:
                float newEnergy = Mathf.Min(shieldMaxEnergy, Time.deltaTime * shieldRegenerationSpeedPerSecond);
                shieldEnergyFloat += newEnergy;
                shieldEnergy = (int)shieldEnergyFloat;

                if (shieldEnergy == shieldMaxEnergy)
                {
                    shieldState = ShieldState.DISABLED;
                }
                break;
        }

        shieldObject.SetActive(shieldState == ShieldState.ENABLED);
        shieldColliderObject.SetActive(shieldState == ShieldState.ENABLED);

        shieldEnergyBar.progress = (float)shieldEnergy / (float)shieldMaxEnergy;

        trigger = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        var damage = collision.gameObject.GetComponent<Damage>();

        var damageAmount = 10;
        if (damage != null)
        {
            damageAmount = damage.amount;
        }

        //Debug.LogError("shield hit, damage: "+ damage.amount);
        shieldEnergy = Math.Max(0, shieldEnergy - damageAmount);
        shieldEnergyFloat = shieldEnergy;
    }
}
