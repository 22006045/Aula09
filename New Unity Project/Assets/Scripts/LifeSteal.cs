using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeSteal : Superpower
{
    [SerializeField]
    private float amountToHeal;
    [SerializeField]
    private float amountOfDamage;

    public override void Activate()
    {
       Heal(amountToHeal);
       DealDamage(amountOfDamage);
    }

    // Update is called once per frame
    void Update()
    {
        amountToHeal = amountOfDamage /10;
    }
}
