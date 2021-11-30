using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBehaviour : MonoBehaviour, IAnimateBehaviour
{   
    [SerializeField]
    private GameObject cube1;
    public float xAngle, yAngle, zAngle;

   public void Animate()
    {
        cube1.transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
    }

    
        
}
