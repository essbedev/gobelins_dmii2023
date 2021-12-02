using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitParticle : MonoBehaviour
{
    public float Elevation;
    public float Polar;
    public float Speed = 1f;
    public float Radius;

    public float Scale = 1f;
    public float RotateSpeed = 1f;

    void Start()
    {
        transform.localScale = Vector3.one*Scale;
        transform.localRotation = Quaternion.Euler(Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f), Random.Range(0.0f, 360.0f));
    }

    void Update()
    {
        transform.Rotate(Vector3.one*RotateSpeed*Time.deltaTime);
        Polar+=Speed*Time.deltaTime;
        transform.localPosition = GetSpherePoint();
    }

    private Vector3 GetSpherePoint()
    {
        float a = Radius * Mathf.Cos(Elevation);
        return new Vector3(
            a * Mathf.Cos(Polar),
            Radius * Mathf.Sin(Elevation),
            a * Mathf.Sin(Polar)
        );
    }
}
