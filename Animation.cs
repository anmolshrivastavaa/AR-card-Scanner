using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public Vector3 rot;

    void update()
    {
        transform.Rotate(rot * Time.deltaTime);
    }
}
