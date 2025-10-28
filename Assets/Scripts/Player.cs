using System.Xml.Serialization;
using UnityEngine;

public class Player : Character, IShootable
{

    [field: SerializeField] public GameObject Bullet {  get; set; }

    [field: SerializeField] public Transform ShootPoint { get; set; }

    public float ReloadTime { get; set; }

    public float WaitTime { get; set; }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Initialize(100);
        ReloadTime = 1.0f;
        WaitTime = 0.0f;
    }

    private void FixedUpdate()
    {
        WaitTime += Time.fixedDeltaTime;
    }

    public void OnHitWith(Enemy enemy)
    {
        TakeDamage(enemy.damageHit);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Enemy enemy = other.gameObject.GetComponent<Enemy>();
        if (enemy != null)
        {
            OnHitWith(enemy);
        }

    
    }

    private void Update()
    {
        Shoot();
    }

    public void Shoot()
    {
        if (Input.GetButtonDown("Fire1") && WaitTime >= ReloadTime)
        {
            var bullet = Instantiate(Bullet, ShootPoint.position, Quaternion.identity);
            Banana banana = bullet.GetComponent<Banana>();
            if (banana != null)
            {
                banana.InitWeapon(20, this);

             
            }
            WaitTime = 0.0f;

        }
    }
}
