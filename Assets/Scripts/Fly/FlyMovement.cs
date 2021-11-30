using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class FlyMovement : MonoBehaviour
{

    public Transform CenterPoint;
    [SerializeField]
    private int _Altitude;
    public int Speed;
    public int Radius;
    public float Randomness = 1.0f;

    private float _angle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _angle += Speed*Time.deltaTime;
        transform.position = new Vector3(CenterPoint.position.x + Mathf.Sin(_angle)*Radius, _Altitude + GetYPosition(), CenterPoint.position.z + Mathf.Cos(_angle)*Radius);
    }

    float GetYPosition(){
        float x = Time.time;
        float y = (Mathf.Sin(x) + Mathf.Sin(2.2f*x+5.52f) + Mathf.Sin(2.9f*x+0.93f) + Mathf.Sin(4.6f*x+8.94f)) / 4.0f;
        return y *Randomness;
    }
}
