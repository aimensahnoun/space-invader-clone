using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyPlayerCollisionController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Monster")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }


    private void OnDisable()
    {
        SceneManager.LoadSceneAsync(0);
    }
}
