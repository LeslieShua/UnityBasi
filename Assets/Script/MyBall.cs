using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{   //선언 -> 초기화 -> 호출
    //velocity 현재 이동 속도
    //AddForce(Vec) : Vec의 방향과 크기로 힘을 줌 
    //ForceMode : 힘을 주는 방식(가속, 무게 반영)
    //AddTorque(Vec) : Vec 방향을 축으로 회전력이 생김 [Vec을 축으로 삼음 이동방향 주의]
    //이미지 파일을 Sprite로 설정해야 UI 적용 가능
    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        //rigid.AddForce(Vector3.up * 10, ForceMode.Impulse); //캐릭터 점프
       
    }

    private void FixedUpdate() {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(h, 0, v);

        rigid.AddForce(vec, ForceMode.Impulse);
        

        
        //#1.속력 바꾸기  EX) new Vector3(x[왼오],y[위아래],z[앞뒤])
        // rigid.velocity = Vector3.forward; 

        //#2.힘을 가하기
        if (Input.GetButtonDown("Jump")) {
            rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
            Debug.Log(rigid.velocity);
        }

    // Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"),
    //                         0,
    //                         Input.GetAxisRaw("Vertical"));
    // rigid.AddForce(vec, ForceMode.Impulse);

    // //#3.회전력
    rigid.AddTorque(Vector3.up);
    }

    private void OnTriggerStay(Collider other) { //충돌이 계속 일어나는 중...
        if(other.name == "Cube"){
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
        }
    }

    public void Jump() {
        rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
        Debug.Log("Jump");
    }

    // // 실제 물리적인 충돌로 발생하는 이벤트
    // private void OnCollisionEnter(Collision other) { }
    // private void OnCollisionStay(Collision other) { }
    // private void OnCollisionExit(Collision other) { }

    // // 콜라이더 충돌로 발생하는 이벤트
    // private void OnTriggerEnter(Collider other) { }
    // private void OnTriggerStay(Collider other) { }
    // private void OnTriggerExit(Collider other) { }
}
