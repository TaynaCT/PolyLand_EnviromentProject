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
        float rotateH = Input.GetAxis("Mouse X");
        float rotateV = Input.GetAxis("Mouse Y");

        transform.Rotate(0, rotateH, 0);

        Camera.main.transform.Rotate(-rotateV, 0, 0);

        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");
        float moveJ = Input.GetAxis("Jump");

        Vector3 movement = new Vector3(moveH, moveJ, moveV);

        playerT.position += movement * Time.deltaTime;
    }
}
