﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tileHolder : MonoBehaviour
{
    [SerializeField] public GameObject nextTile;
    [SerializeField] public GameObject otherTile;
    [SerializeField] public int isOccupied = 0;

    [SerializeField] public int checker;

    // Start is called before the first frame update
    void Start()
    {
       // GameObject.DontDestroyOnLoad(this.gameObject);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
