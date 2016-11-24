using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float Speed;
	
	void FixedUpdate(){

		// 入力をxとzに代入
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis ("Vertical");

		// 同一のGameObjectが持つRigidBodyを取得する。
		Rigidbody rigidbody = GetComponent<Rigidbody>();

		// rigidBodyにx軸とz軸に力を加える。
		rigidbody.AddForce(x * Speed, 0, z * Speed);
	}
}
