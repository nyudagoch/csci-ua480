﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace A01_cew385
{
    public class SpinDiscoBall : MonoBehaviour
    {
        public float speed = 20f;
     
        void Update()
        {
            transform.Rotate(Vector3.up, speed * Time.deltaTime);
        }
    }
}