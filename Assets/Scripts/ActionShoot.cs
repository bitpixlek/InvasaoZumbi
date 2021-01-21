using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionShoot : MonoBehaviour
{
    public float Velocity = 20;
    // Update is called once per frame
    void FixedUpdate()
    {
        Rigidbody bala = GetComponent<Rigidbody>();
        bala.MovePosition(bala.position + transform.forward * Velocity * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider objeto)
    {
        if (objeto.tag == "Inimigo")
        {
            Destroy(objeto.gameObject);
        }

        Destroy(this.gameObject);

        
    }
}
