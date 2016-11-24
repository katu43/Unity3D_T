using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	public Transform target;
	private Vector3 offset;

	void Start(){
		// Playerとの相対距離を求める
		offset = GetComponent<Transform> ().position - target.position;
	}
	
	// Update is called once per frame
	void Update () {
		// 自分の座標にPlayerの相対距離を足した値を設定する
		GetComponent<Transform>().position = target.position + offset;

	}
}
