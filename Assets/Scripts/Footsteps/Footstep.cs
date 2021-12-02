using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footstep : MonoBehaviour
{
    public float Threshold = 1.0f;

    private Material _mat;
    private Transform _player;

    void Start()
    {
        GameObject player = GameObject.Find("Player");
        _player = player.transform;

        Renderer renderer = GetComponent<Renderer>();
        _mat = Instantiate<Material>(renderer.material);
        renderer.material = _mat;
        SetAlpha(0);
    }

    void Update()
    {
        float dist = Vector3.Distance(transform.position, _player.position);
        float progress = (Threshold - dist) / Threshold;
        progress = Mathf.Max(0, progress);
        SetAlpha(progress);
    }

    private void SetAlpha(float progress)
    {
        Color color = _mat.color;
        color.a = progress;
        _mat.color = color;
    }
}
