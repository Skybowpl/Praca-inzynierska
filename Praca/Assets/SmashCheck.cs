using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmashCheck : MonoBehaviour
{
    [SerializeField] private GameObject box;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.tag=="Player" && box.GetComponent<Drag>().getCanKill() == true)
        {
            Destroy(collision.gameObject);
        }

        if(collision.tag == "Enemy" && box.GetComponent<Drag>().getCanKill() == true)
        {
            Destroy(collision.gameObject);
        }
    }
}
