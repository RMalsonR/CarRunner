using UnityEngine;
using System.Collections;

public class MoveBlocks : MonoBehaviour {

	public float Speed;
	void Start () {
	Destroy(gameObject,10);
	}
	
	// Update is called once per frame
	void Update () {
	transform.Translate(Vector3.forward*Time.deltaTime*Speed);
	}
}
