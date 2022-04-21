using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardPlayer : MonoBehaviour
{


    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {

        GameObject player = GameObject.FindWithTag("Player");

        if(player != null)
        {


        Vector3 v3 = (player.transform.position - transform.position).normalized;

        Vector2 v2 = new Vector2(v3.x, v3.y);


        GetComponent<Rigidbody2D>().velocity = v2 * speed;
        }

    }

    
}
