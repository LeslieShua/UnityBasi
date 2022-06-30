using UnityEngine;

public class DeltaTime : MonoBehaviour
{

    //deltaTime 값은 프레임이 적으면 크고, 프레임이 많으면 작음 
    void Update()
    {
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal") *  Time.deltaTime,
             0,
            Input.GetAxisRaw("Vertical") *  Time.deltaTime);
        transform.Translate(vec);
    }
}
