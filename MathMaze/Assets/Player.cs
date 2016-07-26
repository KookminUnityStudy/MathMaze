using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    // 한번 클릭시 움직일 거리
    float movingdistance = 0.1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        // 플레이어의 위치
        Transform ptransform = GetComponent<Transform>();

        // 플레이어의 움직임 조작
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("아래버튼 눌렸습니다.");
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("왼쪽버튼 눌렸습니다.");
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("오른쪽버튼 눌렸습니다.");
        }
    }
}
