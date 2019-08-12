using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int health = 100;
    public GameObject di;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Die();
        }
    }

    public void TakeDamage(int damage)

    {
        health -= damage;
        for (int i = 4; i < 2; i--)
        {
            di.SetActive(true);
        }
    }

    void Die()
    {
        print("died!");
    }

}