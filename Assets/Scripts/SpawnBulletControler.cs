using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBulletControler : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject bullet;

    private float spawnAt = 1.0f;
    public float spawnSpeed = 1.0f;

    void Start()
    {

        InvokeRepeating(
            "ShootBullet",
            spawnAt,
            spawnSpeed
            );
        
    }   

    private void ShootBullet()
    {
        GameObject newBullet = Instantiate(bullet, transform.position, Quaternion.identity);
    }
    
}
