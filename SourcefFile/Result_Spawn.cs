using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Result_Spawn : MonoBehaviour
{
    //public int getPoint;
    public GameObject mategai_01;
    public GameObject mategai_02;
    public GameObject mategai_03;
    GameObject childObject;

    public float span;
    private float currentTime = 0f;
    int i = 0;

    float number = Score.score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if(i < number)
        {
            if(currentTime > span)
            {
                Spawn();
                i++;
                currentTime = 0f;
            }
        }
        if(Input.GetMouseButtonDown(0))
        {
            span=0f;
        }
        
    }

    public void Spawn()
    {
        int rnd = Random.Range(1,4);
        switch(rnd)
        {
            case 1:
                childObject = Instantiate(mategai_01, this.transform);                
                break;
                
            case 2:
                childObject = Instantiate(mategai_02, this.transform);
                break;
                
            case 3:
                childObject = Instantiate(mategai_03, this.transform);
                break;
        }
    }
}
