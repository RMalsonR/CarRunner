using UnityEngine;
using System.Collections;

public class BlockSpawner : MonoBehaviour {

	public GameObject BlockPrefab;
	public float SpawnTime;
	void Start () {
	
	InvokeRepeating("SpawnBlock",0,SpawnTime);
	}
	
	
	void SpawnBlock () {  
	GameObject block = Instantiate(BlockPrefab,transform.position,transform.rotation) as GameObject;
	}
}
