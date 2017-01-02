using UnityEngine;
using System.Collections;

public class newFirstP : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        float front = Input.GetAxis("Vertical");
        Vector3 speed = new Vector3(0, 0, front);
        CharacterController c = GetComponent<CharacterController>();
        c.SimpleMove(speed);
	}
}
