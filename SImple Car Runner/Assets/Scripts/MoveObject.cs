using UnityEngine;
using System.Collections;

public class MoveObject : MonoBehaviour {

	public GameObject moveObject;
	public Transform targetPosition;
	public float Speed;
	void Start () {
	
	}
	
	
	void Update () {
		if(Input.GetKey(KeyCode.Space)){
		if(Vector3.Distance(moveObject.transform.position,targetPosition.position) < 0.5f)
		{
			Destroy(moveObject,2);
		}
		else
		{
			moveObject.transform.position = Vector3.MoveTowards(moveObject.transform.position,targetPosition.position,Time.deltaTime*Speed);
			moveObject.transform.LookAt(targetPosition);
		}
		}
	}

}
