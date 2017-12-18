﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Letter : MonoBehaviour {
    private char _c;
    public TextMesh tMesh;
    public Renderer tRend;

    public bool big = false;

    void Awake() {
        tMesh = GetComponentInChildren<TextMesh>();
        tRend = tMesh.GetComponent<Renderer>();
        visible = false;
    }

    public char c {
        get {
            return (_c);
        }
        set {
            _c = value;
            tMesh.text = _c.ToString();
        }
    }

    public string str {
        get {
            return (_c.ToString());
        }
        set {
            c = value[0];
        }
    }

    public bool visible {
        get {
            return (tRend.enabled);
        }
        set {
            tRend.enabled = value;
        }
    }

    public Color color {
        get {
            return (GetComponent<Renderer>().material.color);
        }
        set {
            GetComponent<Renderer>().material.color = value;
        }
    }

    public Vector3 pos {
        set {
            transform.position = value;
        }
    }
}
