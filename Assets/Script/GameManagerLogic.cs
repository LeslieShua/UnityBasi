using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerLogic : MonoBehaviour
{
    //UI를 사용하려면 UnityEngine.UI 라이브러리 적용 필수
    //맵에 존재하는 아이템 총 갯수
    public int totalItemCount;
    public int stage;
    public Text stageCountText;
    public Text playerCountText;

    private void Awake() {
        stageCountText.text = "/ " + totalItemCount.ToString();
    }

    public void GetItem(int count) {
        playerCountText.text = count.ToString();
    }
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            //Restart..
            SceneManager.LoadScene(stage);
            // SceneManager.LoadScene("Example1_" + (manager.stage+1).ToString());
        }
    }
}
