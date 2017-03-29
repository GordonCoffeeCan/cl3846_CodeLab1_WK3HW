﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetObjectPosition : MonoBehaviour {
    private float speed = 0.1f;

    public Transform target;
    private Transform _spaceShip;
    private Transform _arrow;
    public static Vector2 _screenSize;

    private float spawnTime = 0.8f;

    private void Awake() {
        _spaceShip = GameObject.Find("SpaceShip").transform;
    }

    // Use this for initialization
    void Start () {
        Resize();
	}
	
	// Update is called once per frame
	void Update () {
        spawnTime -= Time.deltaTime;
        if(spawnTime <= 0) {
            spawnTime = 0.8f;
            SpawnTarget();
        }
    }

    private void Resize() {
        Vector3 _screenPosision = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        _screenSize = _screenPosision;

        if (this.gameObject.tag != "background") {
            _spaceShip.position = new Vector3(-_screenPosision.x + 1.18f, -_screenPosision.y + 1.05f, 0);
        } else {
            this.transform.localScale = new Vector2((_screenSize.x * 2) / this.GetComponent<SpriteRenderer>().bounds.size.x, (_screenSize.y * 2) / this.GetComponent<SpriteRenderer>().bounds.size.y);
        }
        
    }

    private void FixedUpdate() {
        
    }

    private void SpawnTarget() {
        if (this.gameObject.tag != "background") {
            Instantiate(target, new Vector3(_screenSize.x + target.GetComponent<SpriteRenderer>().bounds.size.x, Random.Range(_screenSize.y - target.GetComponent<SpriteRenderer>().bounds.size.y, target.GetComponent<SpriteRenderer>().bounds.size.y - _screenSize.y), 0), Quaternion.identity);

        }
    }
}
