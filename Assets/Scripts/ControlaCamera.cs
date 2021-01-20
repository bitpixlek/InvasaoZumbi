using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaCamera : MonoBehaviour
{
    public GameObject Player;

    private Vector3 DistanceCamera;
    // Start is called before the first frame update
    void Start()
    {
        this.DistanceCamera = transform.position - this.Player.transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = this.Player.transform.position + DistanceCamera;
    }
}
