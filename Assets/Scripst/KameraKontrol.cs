using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KameraKontrol : MonoBehaviour
{
    public GameObject top;
    public Vector3 aradakiFark;
    
    void Update()
    {
        transform.position = top.transform.position + aradakiFark;
    }
}
