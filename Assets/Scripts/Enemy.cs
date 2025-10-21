using UnityEngine;

public abstract class Enemy : Character
{
    public int damageHit { get; protected set; }

    public abstract void Behavior();
}
