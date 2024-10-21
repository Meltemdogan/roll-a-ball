using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopKontrol : MonoBehaviour
{
    public Rigidbody fizik;
    public int hiz; 
    public int puan;
    public int objeSayisi;

    void Update()
    {
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");

        Vector3 vektor = new Vector3(yatay, 0, dikey);

        fizik.AddForce(vektor * hiz);
    }

     private void OnTriggerEnter(Collider other) 
     { 
        other.gameObject.SetActive(false);
        puan += 1;
        Debug.Log("Sayac : " +puan);
     }
}
