using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaArma : MonoBehaviour
{
    public GameObject Balas;
    public GameObject ReferenciaCanoArma;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(this.Balas, this.ReferenciaCanoArma.transform.position, this.ReferenciaCanoArma.transform.rotation);
        }
    }
}
