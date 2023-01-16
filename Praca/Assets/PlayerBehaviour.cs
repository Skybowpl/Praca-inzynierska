using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Boss")
        {
            Destroy(this.gameObject);
        }
    }

}
