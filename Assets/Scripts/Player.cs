using System.Xml.Serialization;
using UnityEngine;

public class Player : Character
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Initialize(100);
    }

    public void OnHitWith(Enemy enemy)
    {
        TakeDamage(enemy.damageHit);
    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        Enemy enemy = other.gameObject.GetComponent<Enemy>();
        if(enemy != null)
        {
            OnHitWith(enemy);
        }
    }

   
}
