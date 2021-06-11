using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerPipes : MonoBehaviour
{
    public GameObject pipe;
    public float height;
    public float maxTime;  


    private float timer = 0f;  


    void Start()
    {
        GameObject newPipe = Instantiate(pipe); //Criar uma copia do objeto
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime){
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 20f); //O cano será destruido em 20s
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
