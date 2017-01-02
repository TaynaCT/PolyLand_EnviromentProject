using UnityEngine;
using System.Collections;

public class newFirstP : MonoBehaviour {

    Transform playerT;

	// Use this for initialization
	void Start () {
        playerT = transform;
	}
	
	// Update is called once per frame
	void Update () {
        MovePlayer();
	}

    void MovePlayer()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");
        float moveJ = Input.GetAxis("Jump");

        Vector3 movement = new Vector3(moveH, moveJ, moveV);

        playerT.position += movement * Time.deltaTime;
    }
}
