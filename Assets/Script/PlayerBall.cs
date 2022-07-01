using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBall : MonoBehaviour
{
    public int itemCount;
    public float jumpPower = 20;
    bool isJump;
    Rigidbody rigid; //초기화 넣어줄 변수 rigid.000  (물리 효과)
    
    void Awake()
    {
        isJump = false;  //default 값 false = 점프 하지않고있음
        rigid = GetComponent<Rigidbody>(); //Rigidbody 컴포넌트 초기화
    }

    private void Update() {
        /*if문은 (조건식이 true일때) {로직이 발생하기 때문에}
        !isJump를하면 true가 되기때문에 and 조건식이 합치되면서 실행이 가능.*/

        /* !isJump는 현재상태의 isjump 반대를 뜻함 
         현재 isjump가 true면, !isJump는 false임으로 
         다시 점프를 하기위해선 false의 조건이 성립되어야함 */

        // 점프를 할때 isJump = true가 되니까 && !isJump의 조건에 막혀서 최초 한번만 점프됨
        // 점프중에는 점프를 할수 없는게 주 기능
        if(Input.GetButtonDown("Jump") && !isJump) {
            isJump = true; // 점프를하고 있는 중 true
            rigid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
        }
    }


    private void FixedUpdate() { //기본적인 이동
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        rigid.AddForce(new Vector3(h, 0, v), ForceMode.Impulse);

    }
    // 바닥(floor)에 물리적인 충돌로 인해 !isJump의 조건을 맞춰준다면 계속 점프 가능
    // Colider(없으면 추가) -> Is Trigger 체크
    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.name == "Floor") {
            isJump = false; //바닥에 착지했으니 점프 중이 아니다.
        }
        
    }
}


/* Force
해당 리지드바디(rigidbody)의 질량을 사용해서, 연속적인 힘(force)을 가하는 경우에 사용합니다.

Acceleration	
질량을 무시하고, 리지드바디에(rigidbody)에 연속적인 가속력(Acceleration)을 가합니다.

 Impulse(가장많이 사용)
리지드바디의 질량을 사용해서, 짧은 순간의 힘을 가하는 경우에 사용합니다.

 VelocityChange
질량을 무시하고, 리지드바디(rigidbody)에 속도 변화를 짧은 순간에 적용할 경우에 사용합니다.*/