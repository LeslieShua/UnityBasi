using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCan : MonoBehaviour
{
    //SetActive(bool): 오브젝트 활성화 함수

    public float rotateSpeed;
    void Update()
    {
        transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime,Space.World);
    }
    
    private void OnTriggerEnter(Collider other) {
        //other가 어떤 게임오브젝트인지를 알려주어야한다.
        if(other.name == "Player") {
            PlayerBall player = other.GetComponent<PlayerBall>();
            player.itemCount++;
            gameObject.SetActive(false);
        }
    }
}
