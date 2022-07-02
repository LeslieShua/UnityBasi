using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    //오브젝트는 변수 transform을 항상 가지고 있음
    Transform playerTransForm;
    Vector3 Offset;
    void Awake()
    {
        playerTransForm = GameObject.FindGameObjectWithTag("Player").transform;
        Offset = transform.position - playerTransForm.position;
        //카메라 현재위치 - 플레이어 현재위치 뺀 값을 더해주면 항상 같은 거리를 유지함
    }

    // Update is called once per frame
    void LateUpdate()  //UI UpDate 또는 카메라 이동
    {
        transform.position = playerTransForm.position + Offset;
            
    }
}
