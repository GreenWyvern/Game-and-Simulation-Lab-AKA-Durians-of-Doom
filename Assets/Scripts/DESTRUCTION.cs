﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DESTRUCTION : MonoBehaviour {

    private void OnTriggerExit2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

