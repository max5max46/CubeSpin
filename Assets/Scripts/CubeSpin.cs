using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSipn : MonoBehaviour
{
    [SerializeField] private float spinSpeed;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Rotate(new Vector3(spinSpeed, spinSpeed, spinSpeed));
    }
}