using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepController : MonoBehaviour
{

    public int Count = 10;
    public float Distance = 1.0f;
    public GameObject Footstep;

    void Start()
    {
        for (int i = 0; i < Count; i++)
        {
            GameObject footstep = Instantiate<GameObject>(Footstep,transform);
            footstep.transform.position = new Vector3(Mathf.Sin(Distance*i*10.0f)*.2f,Footstep.transform.position.y,Distance*i);
        }
    }
}
