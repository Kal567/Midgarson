using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyArrow : MonoBehaviour
{
    public PlayerLife playerLife;

    private void Awake()
    {
        playerLife = GameObject.Find("Player 1").GetComponent<PlayerLife>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
           playerLife.TakeDamage(Mathf.RoundToInt( GameManagement.archerEnemyAttack_give));
           Destroy(gameObject);
        }

    }


}