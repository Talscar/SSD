using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenAstroids : MonoBehaviour {

	public genBox thisBox;
	[System.Serializable]public struct genBox
	{
		public Vector3 A;
		public Vector3 B;
	}

	public GameObject InstantiateThing;
	public int spawnCount;
	public scaleRange ScaleThing;
	[System.Serializable]public struct scaleRange
	{
		public int Zero;
		public int One;
	}
	// Use this for initialization
	void Start () {
		for (int i = 0; i < spawnCount; i++) 
		{
			GameObject thisObj = Instantiate (InstantiateThing, null);
			thisObj.transform.position = new Vector3 (Random.Range(thisBox.A.x, thisBox.B.x), Random.Range(thisBox.A.y, thisBox.B.y), Random.Range(thisBox.A.z, thisBox.B.z));
			thisObj.transform.localScale = new Vector3 (Random.Range (ScaleThing.Zero, ScaleThing.One), Random.Range (ScaleThing.Zero, ScaleThing.One), Random.Range (ScaleThing.Zero, ScaleThing.One));
			thisObj.transform.eulerAngles = new Vector3 (Random.Range (0, 360),Random.Range (0, 360),Random.Range (0, 360));
			thisObj.transform.parent = this.gameObject.transform;
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
