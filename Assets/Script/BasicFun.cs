using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basic : MonoBehaviour
{
    private void Start() {
        //h = Input.GetAxisRaw("Horizontal") 등으로 값에 넣어줌으로서 움직일 수 있음
        //x(왼쪽, 오른쪽) y (위, 아래) z(앞, 뒤)
        //int number = 4; //스칼라 값
        //오브젝트는 변수 transform을 항상 가지고 있음
        //Translate: 벡터 값을 현재 위치에 더하는 함수
        Vector3 vec = new Vector3(0, 0, 0); //벡터 값
        transform.Translate(vec);

    }



    //0: 완쪽 1: 오른쪽
    // Update is called once per frame
    void Update()
    {
    if (Input.anyKeyDown)
      Debug.Log("플레이어가 아무 키를 눌렀습니다.");

    if (Input.GetKeyDown(KeyCode.Return)) //Enter키
      Debug.Log("아이템을 구입했습니다.");

    if (Input.GetKey(KeyCode.LeftArrow))
      Debug.Log("왼쪽으로 이동 중.");

    if (Input.GetKeyUp(KeyCode.RightArrow))
      Debug.Log("오른쪽 이동을 멈춤.");


    //마우스 입력 버튼 받으면 true

    // if (Input.GetMouseButtonDown(0))
    //   Debug.Log("미사일 발사");

    if (Input.GetMouseButton(0))
      Debug.Log("미사일 모으는 중...");

    if (Input.GetMouseButtonUp(0))
      Debug.Log("슈퍼 미사일 발사");



    //Edit - Project Settings - Input Manager 에서 Name 인자 받아서 사용
    if (Input.GetButtonDown("Jump"))
      Debug.Log("점프");

    if (Input.GetButton("Jump2"))
      Debug.Log("점프 모으는중...");

    if (Input.GetButtonUp("Jump3"))
      Debug.Log("슈퍼 점프");



    if (Input.GetButton("Horizontal")) 
      Debug.Log("횡 이동"
        + Input.GetAxisRaw("Horizontal"));
    if (Input.GetButton("Vertical"))
      Debug.Log("종 이동"
        + Input.GetAxisRaw("Vertical"));
    }


}
