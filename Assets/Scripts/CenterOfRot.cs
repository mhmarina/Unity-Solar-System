using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterOfRot : MonoBehaviour
{
    [SerializeField] float rotSpeed;
    void Update()
    {
        transform.Rotate(0, rotSpeed * Time.deltaTime * 2, 0);
    }
}
