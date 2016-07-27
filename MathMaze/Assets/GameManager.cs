using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
    // 스택이나 배열을 여기다 저장해야할지?
    public int coinCount = 0; // 일단 배웠던거처럼 먹은 코인 갯수를 저장으로

    void GetCoin()
    {
        coinCount++;
        Debug.Log("동전: " + coinCount);
    }

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
