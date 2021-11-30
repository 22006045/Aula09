using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleBehaviour : MonoBehaviour, IAnimateBehaviour
{   
    [SerializeField]
    private GameObject cube2;
    private Vector3 scaleChange = new Vector3(-0.01f, -0.01f, -0.01f);
    
    // Update is called once per frame
    public void Animate()
    {
        cube2.transform.localScale += scaleChange; 
    }
}
