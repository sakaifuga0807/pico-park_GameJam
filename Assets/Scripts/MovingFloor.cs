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
        // ���݂̏����ړI�n�ɋ߂��ꍇ�B

        if (Vector2.Distance(MovePoints[currentMovePointIndex].transform.position, transform.position) < .1f)
        {
            // �ړI�n�����̃|�C���g�ɃZ�b�g����B
            currentMovePointIndex++;

            // �Ō�܂ōs������A�ŏ��̃|�C���g��ړI�n�ɂ���B
            if(currentMovePointIndex >= MovePoints.Length)
            {
                currentMovePointIndex = 0;
            }
        }

        // ���݂̏��̈ʒu����A�ړI�n�̈ʒu�܂ňړ�����B
        transform.position = Vector2.MoveTowards(transform.position, MovePoints[currentMovePointIndex].transform.position, Time.deltaTime * speed);
    }
}
