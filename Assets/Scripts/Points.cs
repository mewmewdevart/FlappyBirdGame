using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public GameController controller;

    void Start(){
        controller = FindObjectOfType<GameController>();
    }


    void OnTriggerEnter2D(Collider2D colisor){
        
        controller.Score++; //Adicionar um ponto sempre que o personagem encostar
        controller.scoreText.text = controller.Score.ToString();//Modificar o texto 

    }

}
