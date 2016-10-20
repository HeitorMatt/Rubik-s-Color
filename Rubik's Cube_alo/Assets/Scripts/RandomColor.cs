 using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomColor : MonoBehaviour {

	public GameObject EmptyQuadPrefab, spawn1, spawn2, spawn3, checkColorPrefab, spawn4, spawn5, spawn6;
	public List<Color> cores;
	GameObject[] SpawnsArray, checkColorArray;
	List<GameObject> PaintQuadsList;

	void Awake()
	{
		for(int i =0; i < 3; i++)
		{
			GameObject g = (GameObject)Instantiate (checkColorPrefab, checkColorArray [i].transform.position, Quaternion.identity);
		}	
	}

	// Use this for initialization
	void Start () {
		PaintQuadsList = new List<GameObject>();
		SpawnsArray = new GameObject[2];
		checkColorArray = new GameObject[2];
		SpawnsArray [0] = spawn1;
		SpawnsArray [1] = spawn2;
		SpawnsArray [2] = spawn3;
		checkColorArray [0] = spawn4;
		checkColorArray [1] = spawn5;
		checkColorArray [2] = spawn6;
		//print (SpawnsArray.Length);

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
		//print ("ALOO");
		for (int i = 0; i < 3; i++) {
			//print ("Ints" + 1);
			GameObject g = (GameObject)Instantiate (EmptyQuadPrefab, SpawnsArray[i].transform.position, Quaternion.identity);
			PaintQuadsList.Add (g);
			int j = Random.Range(0, cores.Count);
			g.GetComponent<SpriteRenderer> ().color = cores[j];

			//print (PaintQuadsList.Count	);
		}
		foreach(GameObject paint in PaintQuadsList){
			int j = Random.Range(0, cores.Count);
			paint.GetComponent<SpriteRenderer> ().color = cores[j];
		}
	}
}
