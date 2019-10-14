using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	public GameObject Car;
	void Start () {
	Car = GameObject.Find("Car");
	}
	
	// Update is called once per frame
	void Update () {
		if(Car){
		if(Vector3.Distance(Car.transform.position,transform.position) < 1f)
		{
			Destroy(Car);
			Application.LoadLevel(1);
		}
		}
	}
}
