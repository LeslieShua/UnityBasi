using UnityEngine;
//ctrl + k + f 자동정렬
//초기화 -> 물리 -> 게임로직 -> 해체
public class LifeCycle : MonoBehaviour
{
  private void Awake() 
  {  //게임 오브젝트 생성할 때, 최초 실행
    Debug.Log("플레이어 데이터준비");
  }

  private void OnEnable() {
    //게임 오브젝트가 활성화 되었을 때
    Debug.Log("플레이어 로그인");
  }

  private void Start()
  {  // 업데이트 직전, 최초 실행
    Debug.Log("장비 장착");
  }

  private void FixedUpdate() //이동
  {  //물리 연산 업데이트 CPU 부하
    Debug.Log("FixedUpdate_test");
  }

  private void Update()  //사냥
  {  // 게임 로직, 환경에따라 실행주기가 떨어짐 
    Debug.Log("update_test");
  }

  private void LateUpdate()  //경험치
  { //모든 업데이트 끝난 후 실행
    Debug.Log("LateUpdate_test");
  }

  private void OnDisable() {
    //게임 오브젝트가 비활성화 되었을 때
    Debug.Log("플레이어 로그아웃");
  }

  private void OnDestroy() {
    //게임 오브젝트가 삭제될 때
    Debug.Log("플레이어 데이터해제");
  }
}
