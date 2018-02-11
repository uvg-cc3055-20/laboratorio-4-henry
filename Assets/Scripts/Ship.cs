﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour {

    public float speed = 5.0f;
    Rigidbody2D rb;

    // Use this for initialization
    void Start() {
       rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        float movX = Input.acceleration.x;
        transform.Translate(Vector2.right * speed * movX *
        Time.deltaTime);

    }
}
