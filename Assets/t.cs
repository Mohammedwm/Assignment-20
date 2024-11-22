using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class t : MonoBehaviour
{
    public float deg = 0.0f;
    public float angleInc = 0.1f;

    // Update is called once per frame
    void Update()
    {
        deg = deg + angleInc;
        transform.rotation = Quaternion.Euler(new Vector3(deg,0, 0));
    }
}
