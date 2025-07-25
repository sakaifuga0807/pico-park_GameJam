using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    #region 
    [Header("移動速度")] public float speed =5;
    [Header("重力")] public float gravity =3;
    [Header("画面外でも行動する")] public bool nonVisibleAct;
    [Header("接触判定")]public EnemyCollisionCheck checkCollision;
    #endregion

    #region
    private Rigidbody2D rb = null;
    private SpriteRenderer sr = null;
    public float jumpSpeed;
    private float jumpHeight = 20000.0f;
    private float jumpPos;
    private bool rightTleftF = false;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

        
    }

    void FixedUpdate()
    {
        if (sr.isVisible || nonVisibleAct)
        {
            if(checkCollision.isOn)
            {
               rightTleftF = !rightTleftF;
            }

            int xVector = -1;

            if (rightTleftF)
            {
                xVector = 1;
                transform.localScale = new Vector3(-1, 1, 1);
            }

            else
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
            rb.velocity = new Vector2(xVector * speed, -gravity);

            if(checkCollision.isJump)
            {
                //rb.velocity = new Vector2(rb.velocity.x, 0.0f);
                //rb.AddForce(Vector2.up * 200.0f, ForceMode2D.Impulse);
                this.rb.AddForce(transform.up*jumpHeight);
                checkCollision.isJump = false;
            }

        }

        else
        {
            rb.Sleep();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
