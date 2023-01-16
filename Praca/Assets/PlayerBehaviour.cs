using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject gameOver; 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Boss" || collision.gameObject.tag == "End")
        {
            Destroy(this.gameObject);
        }
    }
    private void OnDestroy()
    {
        gameOver.SetActive(true);
    }
}
