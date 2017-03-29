using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour {
    private bool isBallHit = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Space) && isBallHit == false) {
            isBallHit = true;
            //this.GetComponent<Rigidbody2D>().gravityScale = 1;
            
        }

        if(this.transform.position.x > SetObjectPosition._screenSize.x + 10) {
            Destroy(this.gameObject);
            
        }
    }
}
