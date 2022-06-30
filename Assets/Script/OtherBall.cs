using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    //오브젝트의 재질 접근 MeshRenderer을 통해
    //CollisionEnter: 물리적 충돌이 시작할 때 호출되는 함수.
    //Collision: 충돌 정보 클래스
    MeshRenderer mesh;
    Material mat;

    // Start is called before the first frame update
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.name == "My Ball")
        mat.color = new Color(1, 0, 0, 1);
        Debug.Log(collision.gameObject.name); 
    }

    // private void OnCollisionStay(Collision collision) {

    // }

    private void OnCollisionExit(Collision collision) {
            if (collision.gameObject.name == "My Ball")
      mat.color = new Color(1, 0, 0);
    }
}
