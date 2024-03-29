 using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RandomColor : MonoBehaviour {

	public GameObject EmptyQuadPrefab, spawn1, spawn2, spawn3;
	public List<Color> cores;
	GameObject[] SpawnsArray;
	List<GameObject> PaintQuadsList;

	/*void Awake()
	{
		for(int i =0; i < 3; i++)
		{
			GameObject g = (GameObject)Instantiate (checkColorPrefab, checkColorArray [i].transform.position, Quaternion.identity);
		}	
	}*/

	// Use this for initialization
	void Start () {
		PaintQuadsList = new List<GameObject>();
		SpawnsArray = new GameObject[3];
		cores[0] = new Color (0, 0.208f, 1.000f, 1.000f);
		cores[2] = new Color (1f,0.110f, 0.125f, 1f);
		cores[1] =  new Color (1.000f,1.000f,0.008f,1.000f);
		cores[3] = new Color (0.180f,0.773f,0.004f,1f);
		cores[4] = new Color (1f,1f,1f,1f);
		cores[5] = new Color (1,0.522f,0.004f, 1f);
		SpawnsArray [0] = spawn1;
		SpawnsArray [1] = spawn2;
		SpawnsArray [2] = spawn3;

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
		if(Input.GetKeyDown (KeyCode.R))
		{
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
