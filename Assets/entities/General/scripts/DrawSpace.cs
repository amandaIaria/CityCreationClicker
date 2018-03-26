using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawSpace : MonoBehaviour {

	public float width = 10f;
	public float height = 10f;

	public void OnDrawGizmos(){
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireCube(transform.position, new Vector3(width, height) );
	}
}
