using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
    // 床に衝突したときに実行
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 衝突したオブジェクト名がPlayerなら、床の子オブジェクトにする
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }

    // 床から離れたときに実行
    private void OnCollisionExit2D(Collision2D collision)
    {
        // 衝突したオブジェクト名がPlayerなら、床の子オブジェクトから解除する
        if (collision.gameObject.name == "Player")
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}