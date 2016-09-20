 using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomColor : MonoBehaviour {

	public GameObject EmptyQuadPrefab, spawn1, spawn2, spawn3;
	public List<Color> cores;
	GameObject[] SpawnsArray;
	List<GameObject> PaintQuadsList;

	// Use this for initialization
	void Start () {
		PaintQuadsList = new List<GameObject>();
		SpawnsArray = new GameObject[3];
		SpawnsArray [0] = spawn1;
		SpawnsArray [1] = spawn2;
		SpawnsArray [2] = spawn3;
		print (SpawnsArray.Length);
	}
	
	// Update is called once per frame
	void Update () {
		GameObject[] achar = GameObject.FindGameObjectsWithTag ("Empty Paint");
		if(achar.Length == 0)
		{
			//print ("zirow");
			SpawnQuads ();
		}
	}

	void SpawnQuads()
	{
		print ("ALOO");
		for (int i = 0; i < 3; i++) {
			print ("Ints" + 1);
			GameObject g = (GameObject)Instantiate (EmptyQuadPrefab, SpawnsArray[i].transform.position, Quaternion.identity);
			PaintQuadsList.Add (g);
		}
		foreach(GameObject paint in PaintQuadsList){
			int j = Random.Range(0, cores.Count);
			paint.GetComponent<SpriteRenderer> ().color = cores[j];
		}
	}
}
