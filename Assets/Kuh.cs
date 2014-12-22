using UnityEngine;
using System.Collections;

public class Kuh : MonoBehaviour {

    public Vector3 gravity = new Vector3(0, 0.02f, 0);
    public GameObject micVolume;
    public float moveSpeed;
    public byte balloons = 3;
    public GameObject alertWin;
    public GameObject alterLos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate()
    {
        moveSpeed = micVolume.GetComponent<MicrophoneInput>().loudness * 0.01f;
        transform.position = new Vector3(0, transform.position.y + moveSpeed, 0);

        transform.position -= gravity;
    }
}
