﻿using UnityEngine;
using System.Collections;

public class Disappear : MonoBehaviour {

    public float lifeTime;

    // Use this for initialization
    void Start () {
        lifeTime = 2F;
    }
	
	// Update is called once per frame
	void Update () {
        Destroy(this.gameObject, lifeTime);

    }
}
