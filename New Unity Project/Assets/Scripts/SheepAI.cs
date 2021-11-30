using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepAI : AnimalsAI
{
    protected override void TryEat()
    {
        Debug.Log("Ovelha a comer");

    }
    protected override void TryReproduce()
    {
        Debug.Log("Ovelha a fazer o que o passos nao faz");

    }
    
    protected override void Move()
    {
        Debug.Log("Ovelha a mover");

    }
    protected override void SelectTarget()
    {
        Debug.Log("Ovelha a escolher alvo");

    }
}