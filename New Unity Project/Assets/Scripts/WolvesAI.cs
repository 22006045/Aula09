using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolvesAI: AnimalsAI
{
    protected override void TryEat()
    {
        Debug.Log("Wolf a comer");
    }
    protected override void TryReproduce()
    {
        Debug.Log("Wolf a fazer o que o passos nao faz");
    }
    
    protected override void Move()
    {
        Debug.Log("Wolf a mover");
    }
    protected override void SelectTarget()
    {
        Debug.Log("Wolf a escolher alvo");
    }
}
