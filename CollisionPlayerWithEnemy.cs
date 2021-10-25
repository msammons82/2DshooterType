using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionPlayerWithEnemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if(collision.gameObject.tag == "Monster")
        {
            //Destroy player( as he holds this scripts)
            Destroy(gameObject);
            //Destroy enemy as he is the one the player collides with in this case
            Destroy(collision.gameObject);
        }
    }

    private void OnDisable()
    {
        SceneManager.LoadSceneAsync(0);
    }
    
}

