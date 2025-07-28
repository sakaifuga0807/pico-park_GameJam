using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    // ���ɏՓ˂����Ƃ��Ɏ��s
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �Փ˂����I�u�W�F�N�g����Player�Ȃ�A���̎q�I�u�W�F�N�g�ɂ���
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }

    // �����痣�ꂽ�Ƃ��Ɏ��s
    private void OnCollisionExit2D(Collision2D collision)
    {
        // �Փ˂����I�u�W�F�N�g����Player�Ȃ�A���̎q�I�u�W�F�N�g�����������
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}