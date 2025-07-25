using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwichScript : MonoBehaviour
{
    #region
    [Header("スイッチの状態")] public SwichCollisionCheck PressCheck;
    [Header("重力")] public float gravity = 1;
    #endregion
    #region
    private Rigidbody2D rb = null;
    private SpriteRenderer sr = null;
    private bool OnPress = false;
    #endregion
  

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        
    }
    void FixedUpdate()
    {
            if (PressCheck.isPress)
            {
                sr.color=Color.red;
            }



            else
            {
                sr.color = Color.white;
            }
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
