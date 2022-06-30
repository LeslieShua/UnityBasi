using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour
{
    //ref: 애니메이션 처리

    Vector3 target = new Vector3(4, 1.5f, 0); //target 원하는 위치의 값

    //매개변수는(현재위치, 목표위치, 참조 속도, 속도)
    void Update()
    {
        //1.MoveTowards (단순 등속 이동)
        transform.position =    
            Vector3.MoveTowards(transform.position, target, 1f);
        //2.SmoothDamp (미끄러지듯이 감속 이동)
        Vector3 velo = Vector3.zero;
        transform.position =
            Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);

        //3.Lerp (선형 보간 이동)
        transform.position = 
            Vector3.Lerp(transform.position, target, 0.005f);

       //4.SLerp (구면 선형 보간 이동)
       transform.position = 
            Vector3.Slerp(transform.position, target, 0.005f);
    }
}
