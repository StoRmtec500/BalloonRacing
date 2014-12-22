using UnityEngine;
using System.Collections;

public class Hand : MonoBehaviour {

    public float moveSpeed = 0.02f;
    public float currentPos;
    public bool left = false;

	// Use this for initialization
	void Start () {
        currentPos = transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
        if (!left)
        {
            transform.position -= new Vector3(moveSpeed, 0, 0);
        }
        else
        {
            transform.position += new Vector3(moveSpeed, 0, 0);
        }

        if (transform.position.x <= currentPos - 0.7f)
        {
            moveSpeed *= -1;
        }
        if (transform.position.x >= currentPos + 0.7f)
        {
            moveSpeed *= -1;
        }
	}
}
