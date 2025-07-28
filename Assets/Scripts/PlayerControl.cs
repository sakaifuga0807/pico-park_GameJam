using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private float SPEED = 0.02f;
    private float JUMP = 2.5f;
    private int Ground = 0;
    //private Vector2 _inputDirection;
    //private Animator _anim;

    // Start is called before the first frame update
    void Start()
    {
        //_anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //_inputDirection.x = 0.0f;

        //_anim.SetBool("Walk", _inputDirection.x != 0.0f);

        Vector2 position = transform.position;

        // Dキーが押している間。
        if(Input.GetKey(KeyCode.D))
        {
            // ログでポジションを表示する。
            Debug.Log(position);
            // 右に移動する。
            position.x += SPEED;

            //_inputDirection.x = 1.0f;
        }
        // Aキーを押している間。
        if(Input.GetKey(KeyCode.A))
        {
            // ログでポジションを表示する。
            Debug.Log(position);
            // 左に移動する。
            position.x -= SPEED;

            //_inputDirection.x = 1.0f;
        }
        // スペースキーを押している間。
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (Ground == 0)
            {
                Debug.Log("Jump");
                // ジャンプする。
                position.y += JUMP;
            }
        }

        // ポジションを保持する。
        transform.position = position;
    }

    // 地面と接触した時。
    void OnTriggerStay2D(Collider2D col)
    {
        if(col.tag == "Ground")
        {
            // ログでGroundと表示する。
            Debug.Log("Ground");
            if(col.tag == "Ground")
            {
                Ground = 0;
            }
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("out");
        if(col.tag == "Ground")
        {
            Ground = 1;
        }
    }
}
