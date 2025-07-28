using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingFloor : MonoBehaviour
{
    [SerializeField] private GameObject[] MovePoints;
    private int currentMovePointIndex = 0;

    [SerializeField] private float speed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        // 現在の床が目的地に近い場合。

        if (Vector2.Distance(MovePoints[currentMovePointIndex].transform.position, transform.position) < .1f)
        {
            // 目的地を次のポイントにセットする。
            currentMovePointIndex++;

            // 最後まで行ったら、最初のポイントを目的地にする。
            if(currentMovePointIndex >= MovePoints.Length)
            {
                currentMovePointIndex = 0;
            }
        }

        // 現在の床の位置から、目的地の位置まで移動する。
        transform.position = Vector2.MoveTowards(transform.position, MovePoints[currentMovePointIndex].transform.position, Time.deltaTime * speed);
    }
}
