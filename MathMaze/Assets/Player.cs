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

        int speed = 2; // 1초마다 2만큼씩 간다는 얘기 Time.deltatTime이 초마다
        int distance = 1; // 한번에 이동거리

        // 플레이어의 움직임 조작
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, 0, distance) * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, 0, -distance) * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-distance, 0, 0) * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(distance, 0, 0) * Time.deltaTime * speed);
        }
    }
}
