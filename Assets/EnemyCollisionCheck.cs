using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyCollisionCheck : MonoBehaviour
{
    [HideInInspector] public bool isOn = false;
    [HideInInspector] public bool isJump = false;
    [HideInInspector] public bool isDead = false;
    private string groundTag = "Ground";
    private string enemyTag = "Enemy";
    private string playerTag = "Player";
    private string springTag = "Spring";
    private string enemyattackTag = "EnemyAttack";

    #region
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == groundTag||collision.tag ==enemyTag||collision.tag ==enemyattackTag)
        {
            isOn = true ;
        }

        if (collision.CompareTag(springTag))
        {
            isJump = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag ==groundTag||collision.tag== enemyTag||collision.tag==enemyattackTag)
        {
            isOn = false;
        }

        if (collision.CompareTag(springTag))
        {
            isJump = false;
        }
    }
    #endregion

    #region
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == playerTag)
        {
            isDead = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == playerTag)
        {
            isDead = false;
        }
    }
    #endregion
}
