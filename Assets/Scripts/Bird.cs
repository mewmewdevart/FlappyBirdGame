using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float speed = 1f; //Controlar a velocidade
    private Rigidbody2D rig; //Controlar o Rigidbody(Fisica) do Passarinho

    public GameObject GameOver;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){ //Quando o botão esquerdo for pressionado

            rig.velocity = Vector2.up * speed;

        }
    }

    void OnCollisionEnter2D(Collision2D colisor) {
        GameOver.SetActive(true);
        Time.timeScale = 0 ; //pausando o jogo

    }
}
