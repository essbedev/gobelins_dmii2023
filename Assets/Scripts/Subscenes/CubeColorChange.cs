using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColorChange : MonoBehaviour
{
    private Material _mat;
    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        _mat = Instantiate(renderer.material);
        renderer.material = _mat;

        SceneController.Instance.OnOpenScene += OnSceneOpened;
    }

    private void OnSceneOpened(string scene)
    {
        _mat.color = Color.green;
    }

    void OnDestroy(){
        SceneController.Instance.OnOpenScene -= OnSceneOpened;
    }
}
