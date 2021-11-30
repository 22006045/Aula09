using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flash : Superpower
{
    [SerializeField]
    private float speed;
    
    public override void Activate()
    {
        BoostSpeed(speed);
        if(speed >= 10)
        {
            LightMyFire();
        }
    }

    // Update is called once per frame
    
}
