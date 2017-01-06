using UnityEngine;
using System.Collections;

public class newFirstP : MonoBehaviour {

    Transform playerT;
    public float mSpeed;
    public float rangeY = 75f;

    public float rotateV = 0;

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
        transform.Rotate(0, rotateH, 0);

        rotateV -= Input.GetAxis("Mouse Y");
        rotateV = Mathf.Clamp(rotateV, -rangeY, rangeY);
        Camera.main.transform.localRotation = Quaternion.Euler(rotateV,0,0);

        
        //Player M
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveH,0, moveV);

        movement = transform.rotation * movement;

        playerT.position += movement * Time.deltaTime;
    }
}
