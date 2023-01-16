using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmashCheck : MonoBehaviour
{
    [SerializeField] private GameObject box;
    [SerializeField] private Rigidbody2D rb;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player" && box.GetComponent<Drag>().getCanKill() == true && rb.velocity.y < -1.2)
        {
            Destroy(collision.gameObject);
        }

        if(collision.tag == "Enemy" && box.GetComponent<Drag>().getCanKill() == true && rb.velocity.y < -1.2)
        {
            Destroy(collision.gameObject);
        }
        if(collision.tag == "Boss" && box.GetComponent<Drag>().getCanKill() == true && rb.velocity.y < -1.2)
        {
            collision.gameObject.GetComponent<BossBehaviour>().RemoveHealth();
            Destroy(transform.parent.gameObject);
        }

    }
}
