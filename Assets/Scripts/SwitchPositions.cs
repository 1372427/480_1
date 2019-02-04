using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPositions : MonoBehaviour {

    public Vector3[] positions;
    public int currPosIndex = 0;
    public float t;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position = Vector3.Lerp(positions[currPosIndex%positions.Length], positions[(currPosIndex+1)%positions.Length], t);
        t += 0.01f;
	}

    public void SwitchPosition()
    {
        currPosIndex++;
        t = 0;
    }
}
