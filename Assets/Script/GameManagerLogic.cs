using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerLogic : MonoBehaviour
{
    //맵에 존재하는 아이템 총 갯수
    public int totalItemCount;
    public int stage;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            SceneManager.LoadScene(stage);
            // SceneManager.LoadScene("Example1_" + (manager.stage+1).ToString());
        }
    }
}
