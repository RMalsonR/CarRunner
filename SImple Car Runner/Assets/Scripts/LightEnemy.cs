using UnityEngine;
using System.Collections;

public class LightEnemy : MonoBehaviour {

	public GameObject _target;
	public Vector3 Rotation;
	public float speed;
	Quaternion startRotation;
	void Start()
	{
		startRotation = transform.rotation;
	}
		
	void Update () {
		if(_target)
		{
			transform.LookAt(_target.transform);
		}
		else
		{
			transform.Rotate(Rotation * Time.deltaTime*speed);
		}
		
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.GetComponent<PlayerControllers>())
		{
			_target = other.gameObject;
		}
	}

	void OnTriggerExit(Collider other)
	{
		if(other.GetComponent<PlayerControllers>())
		{
			_target = null;
			transform.rotation = startRotation;
		}
	}
}
