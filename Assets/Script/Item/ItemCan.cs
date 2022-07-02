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
    
}
