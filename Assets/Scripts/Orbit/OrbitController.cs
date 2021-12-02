using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitController : MonoBehaviour
{

    public float MinRadius = 4f;
    public float RadiusRandom = 1f;

    public float MinSpeed = 0f;
    public float SpeedRandom = 1f;

    public float ElevationAngle = 20;

    public float MinScale = .1f;
    public float ScaleRandom = .5f;
    public float MinLocalRotation = 0f;
    public float LocalRotationRandom = 1f;

    public int Count;
    public GameObject[] Prefabs;
    public Material[] Materials;
    private OrbitParticle[] _particles;

    // Start is called before the first frame update
    void Start()
    {
        _particles = new OrbitParticle[Count];

        for (int i = 0; i < Count; i++)
        {
            GameObject g = Instantiate<GameObject>(Prefabs[Random.Range(0,Prefabs.Length)], transform);
            OrbitParticle p = g.AddComponent<OrbitParticle>();
            p.Polar = Mathf.PI*2f*Random.value;
            p.Elevation = (Random.value*2f-1f) * ElevationAngle * Mathf.Deg2Rad;
            p.Radius = MinRadius + Random.value*RadiusRandom;
            p.Speed = MinSpeed + Random.value * SpeedRandom;
            p.Scale = MinScale + Random.value * ScaleRandom;
            p.RotateSpeed = MinLocalRotation + Random.value * LocalRotationRandom;
            _particles[i] = p;
            g.GetComponent<Renderer>().material = Materials[Random.Range(0,Materials.Length)];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
