﻿using UnityEngine;
using System.Collections;



// A Simple script to resize a sprite to screen size given an orthographic camera.
[RequireComponent(typeof(SpriteRenderer))]
public class ResizeToScreen : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        if (sr == null) return;

        transform.localScale = new Vector3(1, 1, 1);

        float width = sr.sprite.bounds.size.x;
        float height = sr.sprite.bounds.size.y;

        float worldScreenHeight = Camera.main.orthographicSize * 2.0f;
        float worldScreenWidth = worldScreenHeight / Screen.height * Screen.width;

        transform.localScale = new Vector3(worldScreenWidth / width, worldScreenHeight / height);
    }
}
