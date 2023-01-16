using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehaviour : MonoBehaviour
{
    [SerializeField] private GameObject box;
    [SerializeField] private Animator animator;
    [SerializeField] private HealthBar healthBar;
    private float nextActionTime = 5.0f;
    private float period = 1.0f;
    private int health=4;

    private void Start()
    {
        healthBar.setSlider(health);
    }
    void Update()
    {
        if (Time.time >= nextActionTime)
        {
            animator.SetTrigger("Summon");
            nextActionTime += period;
            Instantiate(box, new Vector3(Random.Range(-8,3), 5.7f, 0), Quaternion.identity);

        }
    }
    public void RemoveHealth()
    {
        health--;
        healthBar.setSlider(health);
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
