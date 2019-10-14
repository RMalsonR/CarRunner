using UnityEngine;
using System.Collections;

public class BunnyControllerAnimator : MonoBehaviour {

	Animator animController;

	// Use this for initialization
	void Start () {
	animController = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	if(Input.GetMouseButtonDown(0))
	{
		animController.SetBool("idleBool",true);
	}
	if(Input.GetMouseButtonDown(1))
	{
		animController.SetBool("idleBool",false);
	}
	if(Input.GetKeyDown(KeyCode.Space))
	{
		animController.SetInteger("life",0);
	}
	}
}
