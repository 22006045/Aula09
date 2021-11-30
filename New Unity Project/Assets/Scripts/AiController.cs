using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiController : MonoBehaviour
{
    private IEnumerable<AnimalsAI> AnimalsAI;

    private IEnumerator Taketurns()
    {
        while(true)
        {
            yield return new WaitForSeconds(2);
            
            foreach (AnimalsAI animal in AnimalsAI)
            {
                animal.TakeTurn();
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
      StartCoroutine(Taketurns());  
    }

    // Update is called once per frame
    void Awake()
    {
        AnimalsAI = new AnimalsAI[]{new SheepAI(), new WolvesAI()};
    }
}
