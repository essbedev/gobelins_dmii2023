using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitController : MonoBehaviour
{

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
            p.Elevation = (Random.value*2f-1f) * .02f * Mathf.PI;
            p.Radius = 4.5f + Random.value*.5f;
            p.Speed = .5f + Random.value * .5f;
            _particles[i] = p;
            g.GetComponent<Renderer>().material = Materials[Random.Range(0,Materials.Length)];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
