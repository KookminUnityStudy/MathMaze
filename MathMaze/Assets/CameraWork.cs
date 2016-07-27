using UnityEngine;
using System.Collections;

public class CameraWork : MonoBehaviour {
    public GameObject player;
    int heigth = 3; // 카메라 높이
    int distance = 6; // 카메라 거리

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(0
            , player.transform.position.y + heigth
            , player.transform.position.z - distance);
	}
}
