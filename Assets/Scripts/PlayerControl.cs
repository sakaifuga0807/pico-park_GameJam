using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    private float SPEED = 0.03f;
    private float JUMP = 2.5f;
    private int Ground = 0;

    [SerializeField] GameObject gameOverText;

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

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Trap")
        {
            GameOver();
        }
        
        if(col.tag == "Stage1Clear")
        {
            SceneManager.LoadScene("PicoPark-Title");
        }
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

    void GameOver()
    {
        // ゲームオーバーテキストを表示する。
        //gameOverText.SetActive(true);

        // プレーヤーのオブジェクトを非表示にする。
        this.gameObject.SetActive(false);

        // 現在のシーンを再ロードする。
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        // ログでGameOverと表示する。
        Debug.Log("GameOver");
    }
}
