using UnityEngine;

public class Ant : Enemy
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Initialize(40);
    }

    public override void Behavior()
    {
        throw new System.NotImplementedException();
    }

    
}
