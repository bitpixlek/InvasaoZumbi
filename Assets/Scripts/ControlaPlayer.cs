using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{

    //}

    public float Velocity = 10;
    private Vector3 Direction;
    public LayerMask chao;
    public GameObject GameOver;

    // Update is called once per frame
    void Update()
    {
        Rigidbody rigidBody = GetComponent<Rigidbody>();
        var eixoX = Input.GetAxis("Horizontal");
        var eixoZ = Input.GetAxis("Vertical");
        this.Direction = new Vector3(eixoX, 0, eixoZ);

        if (this.Direction != Vector3.zero)
            GetComponent<Animator>().SetBool("Moving", true);
        else
            GetComponent<Animator>().SetBool("Moving", false);
    }

    void FixedUpdate()
    {
        Rigidbody rigidBody = GetComponent<Rigidbody>();
        rigidBody.MovePosition
            (rigidBody.position +
                this.Direction * this.Velocity * Time.deltaTime
            );

        Ray raio = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(raio.origin, raio.direction * 100, Color.red);

        RaycastHit impact;
        if (Physics.Raycast(raio, out impact, chao))
        {
            Vector3 posicaoMira = impact.point - transform.position;
            posicaoMira.y = transform.position.y;

            Quaternion mira = Quaternion.LookRotation(posicaoMira);
            rigidBody.MoveRotation(mira);
        }
    }
}
