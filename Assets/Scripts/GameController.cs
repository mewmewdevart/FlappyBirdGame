using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  //Controlador geral do jogo
using UnityEngine.UI;



public class GameController : MonoBehaviour
{
    public int Score;
    public Text scoreText;

    //O "START" é Chamado uma vez ao inicializar o jogo
    void Start(){
        Time.timeScale=1;
    }

    public void RestartGame(){
        SceneManager.LoadScene(0); //Reinicia o jogo 
    }
}
