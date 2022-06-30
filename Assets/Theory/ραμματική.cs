using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    //0.키워드
    string title = "전설의";
    string playerName = "검사";
    int level = 5;
    float strength = 15.5f;
    int exp = 1500;
    int health = 30; 
    int mana = 25;
    bool isFullLevel = false;
    void Start()
    {
        Debug.Log("Hello Unity!");

        //1.변수

        //2.그룹형 변수
        string[] monster = {"슬라임", "사막뱀", "악마" };
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        List<string> items = new List<string>();
        items.Add("HP 30회복");
        items.Add("MP 20회복");

        //3.연산자

        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        Debug.Log("총 경험치");
        Debug.Log(exp);

        int nextExp = 300 - (exp % 300);
        Debug.Log("다음 레벨까지 남은 경험치");
        Debug.Log(nextExp);

        int fullLevel = 100;
        isFullLevel = level == fullLevel;
        Debug.Log("플레이어는 만렙입니까?"); //false

        bool isEndTutorial = level > 10;
        Debug.Log("튜토리얼이 끝난 용사입니까?" + isEndTutorial); //false 

        int health = 30;
        int mana = 15;
        //<=  이상이거나 이하이거나
        // bool isBadCondition = health <= 50 && mana <=20;  //and 한개라도 false면 false
        bool isBadCondition = health <= 50 || mana <=20;  //or 두 값 중에 하나만 true면 true

        // Debug.Log("플레이어 상태가 나쁩니까?" + isBadCondition);
        //삼항연산자  true 값 : false 값
        string condition = isBadCondition ? "나쁨" : "좋음";


        //4.조건문
        if(condition == "나쁨"){
            Debug.Log("플레이어 상태가 나쁩니다");
        }
        else {
            Debug.Log("플레이어 상태가 나쁩니다");
        }

        if (isBadCondition && items[0] == "HP 30회복"){
            items.RemoveAt(0);
            health += 30;
            Debug.Log("HP 30회복 합니다");
        } else if (isBadCondition && items[0] == "MP 20회복"){
             items.RemoveAt(1);
            mana += 20;
            Debug.Log("MP 20회복 합니다");
        }

        switch (monster[1]) {
            case "사막뱀":
            case "슬라임":
                    Debug.Log("소형 몬스터 출현");
                break;
            case "악마":
                    Debug.Log("중형 몬스터 출현");
                break;
            case "골렘":
                    Debug.Log("대형 몬스터 출현");
                break;
            default: //모든 case를 통과한 후 실행
                Debug.Log("??? 몬스터 출현");
                break;
            }

       //5. 반복문
       while (health > 0) {
        health--;
        if(health > 0){
            Debug.Log("독 데미지 입는중" + health);
        } else {
            Debug.Log("사망..");
        }
        
        if (health == 10){
            Debug.Log("해독제 사용");
            break;
        }
       }

       //for문 (연산될 변수선언; 조건; 연산){ 로직 }
       for (int count = 10; count < 10; count++) {
            health++;
            Debug.Log("붕대 감는중.." + health);
       }

        for (int index = 0; index < monster.Length; index++) {
            Debug.Log("현재 몬수터 수" + monster[index]);
       }

       //foreach문
       foreach (string Monster in monster){
        Debug.Log("현재 몬스터 숫자" + monster);
       }

       //6. 함수 (메소드)
        // health = Heal(health); //매계 변수를 가지고 있음
        Heal(); //매개 변수 없음

        for (int index = 0; index < monster.Length; index++)
        {
            Debug.Log("용사는 " + monster[index] + "에게" + 
                Battel(monsterLevel[index]));
        }
        
        //7.클래스 Bird는 클레스명과 파일명이 동일해야함
        // Bird player = new Bird(); 부모 class (결론은 둘다 가능)
        Player player = new Player(); //Player = 자식 class 
        player.id = 0;
        player.name = "참새";
       
        Debug.Log(player.Fly());
        
        player.LevelUp();
        player.move(); //player가 Bird를 상속받아 쓰는 것


    }

       


       int Heal(int currentHealth) //매계 변수를 가지고 있음 + 리턴 값 있음
       {
        health += 10;
        Debug.Log("HP 10회복" + health);
        return health;
       }

       void Heal() //리턴 값 없음
       {
        health += 10;
        Debug.Log("HP 10회복" + health);
       }


       string Battel(int monsterLevel)
        {
            string result;
            if (level >= monsterLevel){
                result = "이겼습니다";
            } else {
                result = "졌습니다";
            }
            return result;
        }
}
