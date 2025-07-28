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

        // D�L�[�������Ă���ԁB
        if(Input.GetKey(KeyCode.D))
        {
            // ���O�Ń|�W�V������\������B
            Debug.Log(position);
            // �E�Ɉړ�����B
            position.x += SPEED;

            //_inputDirection.x = 1.0f;
        }
        // A�L�[�������Ă���ԁB
        if(Input.GetKey(KeyCode.A))
        {
            // ���O�Ń|�W�V������\������B
            Debug.Log(position);
            // ���Ɉړ�����B
            position.x -= SPEED;

            //_inputDirection.x = 1.0f;
        }
        // �X�y�[�X�L�[�������Ă���ԁB
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (Ground == 0)
            {
                Debug.Log("Jump");
                // �W�����v����B
                position.y += JUMP;
            }
        }

        // �|�W�V������ێ�����B
        transform.position = position;
    }

    // �n�ʂƐڐG�������B
    void OnTriggerStay2D(Collider2D col)
    {
        if(col.tag == "Ground")
        {
            // ���O��Ground�ƕ\������B
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
