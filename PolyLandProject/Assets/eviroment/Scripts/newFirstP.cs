using UnityEngine;
using System.Collections;

public class newFirstP : MonoBehaviour {

    Transform playerT;
    public float mSpeed;

	// Use this for initialization
	void Start () {
        playerT = transform;        
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        MovePlayer();
	}

    void MovePlayer()
    {
        float rotateH = Input.GetAxis("Mouse X");
        float rotateV = Input.GetAxis("Mouse Y");

        transform.Rotate(0, rotateH, 0);
        Camera.main.transform.Rotate(-rotateV, 0, 0);

        
        //Player M
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveH,0, moveV);

        movement = transform.rotation * movement;

        playerT.position += movement * Time.deltaTime;
    }
}
