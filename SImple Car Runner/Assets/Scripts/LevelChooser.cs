using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class LevelChooser : MonoBehaviour {

	public Text levelName;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnStartButton()
	{
		Debug.Log("OnStartButton()");
	}
	void OnValueChanged(bool isOn)
	{
		Debug.Log("OnLevelChoose()" + isOn);
	}
}
