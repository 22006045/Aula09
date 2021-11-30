using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerController : MonoBehaviour
{   
    [SerializeField]
    private float seconds;

    private IEnumerable<Superpower> powers;

    private void Awake()
    {
        powers = GetComponents<Superpower>();
    }

    void Start()
    {
        StartCoroutine(ActivatePowers());
    }

    private IEnumerator ActivatePowers()
    {
        while (true)
        {
           yield return new WaitForSeconds(seconds);
           foreach (Superpower p in powers)
           {
               p.Activate();
           }
        }
    }

    
}
