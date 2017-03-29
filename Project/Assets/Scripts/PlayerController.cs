using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed = 5;
    public Rigidbody2D bullet;

    private Rigidbody2D _rig;

    private void Awake() {
        _rig = this.GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Rigidbody2D _bullet;
            _bullet = Instantiate(bullet, this.transform.position, Quaternion.identity) as Rigidbody2D;
            _bullet.AddForce(new Vector2(10, 0), ForceMode2D.Impulse);
            Physics2D.IgnoreCollision(this.GetComponent<BoxCollider2D>(), _bullet.GetComponent<Collider2D>());
        }
	}

    private void FixedUpdate() {
        _rig.velocity = new Vector2(0, speed * Input.GetAxis("Vertical"));
    }
}
