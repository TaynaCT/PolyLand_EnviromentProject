using UnityEngine;
using System.Collections;

public class newEnemies : MonoBehaviour {


    GameObject Player;
    Transform EnemyT;


	// Use this for initialization
	void Start () {
        Player = GameObject.FindGameObjectWithTag("PlayerMe");
        EnemyT = Player.transform;
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        Move();
	}

    void Move()
    {
        Vector3 move = EnemyT.position - transform.position;
        move.Normalize();
        transform.position += move * Time.deltaTime;
    }


}
