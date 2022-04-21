using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{


    public GameObject monster1;
    public GameObject monster2;

    public float interval = 3;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMonster", interval, interval);
    }

   private void SpawnMonster()
    {
        float randomValue= Random.value;

        if(randomValue < 0.2)
        {
            GameObject monster = Instantiate(monster1, transform.position, Quaternion.identity);
        }else if ( randomValue < 0.2)
        {
            GameObject monster = Instantiate(monster2, transform.position, Quaternion.identity);
        }
    }
}
