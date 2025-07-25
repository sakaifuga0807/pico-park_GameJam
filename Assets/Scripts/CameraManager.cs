using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(player.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        if(player.transform.position.x > 0.55f && player.transform.position.x < 60.4)
        {
            transform.position = new Vector3(player.transform.position.x, 0.0f, -10);
        }
    }
}
