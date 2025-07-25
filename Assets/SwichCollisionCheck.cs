using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwichCollisionCheck : MonoBehaviour
{
    [HideInInspector] public bool isPress = false;
    private string playerTag = "Player";
    private string enemyTag = "Enemy";

    #region

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")||collision.CompareTag("Enemy"))
        {
            isPress = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")||collision.CompareTag("Enemy"))
        {
                isPress = false;
        }
    }
    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
