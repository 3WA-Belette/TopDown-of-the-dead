using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Animal
{
    protected virtual void Crier()
    {
        Debug.Log("je crie");
    }

}

class Cheval : Animal
{
    protected override void Crier()
    {
        Debug.Log("JE HENIE");
    }
}

class Chien : Animal
{
    protected override void Crier()
    {
        Debug.Log("J'ABOIS");
    }
}

class Canard : Animal
{
    protected override void Crier()
    {
        Debug.Log("je coincointe");
    }
}



