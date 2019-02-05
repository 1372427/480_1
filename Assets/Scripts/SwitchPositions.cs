using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPositions : MonoBehaviour {

    public Vector3[] positions;
    public int currPosIndex = 0;
    public float t;
    public bool cont = false;
    public bool reset = false;

	// Use this for initialization
	void Start () {
        gameObject.transform.position = positions[currPosIndex];
        t = 1;
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position = Vector3.Lerp(positions[currPosIndex%positions.Length], positions[(currPosIndex+1)%positions.Length], t);
        t += 0.01f;

        if (cont && t>=1)
        {
            SwitchPosition();
        }
	}

    public void SwitchPosition()
    {
        currPosIndex++;
        if (reset && currPosIndex % positions.Length == (positions.Length-2))
        {
            gameObject.transform.position = positions[0];
            currPosIndex++;
        }
        t = 0;
    }

    public void TurnOnOff()
    {
        cont = !cont;
        //if (cont) SwitchPosition();
    }
}
