using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

public class Example : MonoBehaviour {

    public int bump;

    [ColorLine(1f, 0f, 0f)]
    public string baba;

    [SpriteShow]
    public Sprite thing;

    [VectorScale]
    public Vector3 blah;

    // Use this for initialization
    void Start ()
    {
         
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
