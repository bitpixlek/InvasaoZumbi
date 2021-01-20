using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlaZumbi : MonoBehaviour
{
    public GameObject Player;
    public float Velocity = 5;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        Animator animacao = GetComponent<Animator>();
        Rigidbody body = GetComponent<Rigidbody>();
        Vector3 direcao = Player.GetComponent<Rigidbody>().position - body.position;
        Quaternion rotation = Quaternion.LookRotation(direcao);
        body.MoveRotation(rotation);
        float distance = Vector3.Distance(body.position, Player.GetComponent<Rigidbody>().position);
        if (distance > 2.5)
        {
            body.MovePosition(
                body.position + (direcao.normalized * Velocity * Time.deltaTime)
            );

            animacao.SetBool("Atacando", false);
        }
        else
        {
            //Destroy(Player);
            animacao.SetBool("Atacando", true);
        }
    }

    void AtacaJogador()
    {
        Time.timeScale = 0;
        Player.GetComponent<ControlaPlayer>().GameOver.SetActive(true);
    }
}
