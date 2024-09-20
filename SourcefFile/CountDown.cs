using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CountDown : MonoBehaviour
{
    public float tenTime= 90;
    public float oneTime = 10;
    public Image image_1;
    public Image image_2;

    public Sprite timeNumber_0;
    public Sprite timeNumber_1;
    public Sprite timeNumber_2;
    public Sprite timeNumber_3;
    public Sprite timeNumber_4;
    public Sprite timeNumber_5;
    public Sprite timeNumber_6;
    public Sprite timeNumber_7;
    public Sprite timeNumber_8;
    public Sprite timeNumber_9;

    void Start()
    {

    }

    void Update()
    {
        tenTime -= Time.deltaTime;
        oneTime -= Time.deltaTime;

        if(tenTime>=80)
        {
            image_1.sprite = timeNumber_8;
        }
        else if(tenTime>70)
        {
            image_1.sprite = timeNumber_7;
        }
        else if(tenTime>60)
        {
            image_1.sprite = timeNumber_6;
        }
        else if(tenTime>50)
        {
            image_1.sprite = timeNumber_5;
        }
        else if(tenTime>40)
        {
            image_1.sprite = timeNumber_4;
        }
        else if(tenTime>30)
        {
            image_1.sprite = timeNumber_3;
        }
        else if(tenTime>20)
        {
            image_1.sprite = timeNumber_2;
        }
        else if(tenTime>10)
        {
            image_1.sprite = timeNumber_1;
        }
        else if(tenTime>0)
        {
            image_1.sprite = timeNumber_0;
        }

        


        if(oneTime>=9)
        {
            image_2.sprite = timeNumber_9;
        }

        else if(oneTime>8)
        {
            image_2.sprite = timeNumber_8;
        }
        else if(oneTime>7)
        {
            image_2.sprite = timeNumber_7;
        }

        else if(oneTime>6)
        {
            image_2.sprite = timeNumber_6;
        }

        else if(oneTime>5)
        {
            image_2.sprite = timeNumber_5;
        }

        else if(oneTime>4)
        {
            image_2.sprite = timeNumber_4;
        }

        else if(oneTime>3)
        {
            image_2.sprite = timeNumber_3;
        }

        else if(oneTime>2)
        {
            image_2.sprite = timeNumber_2;
        }

        else if(oneTime>1)
        {
            image_2.sprite = timeNumber_1;
        }

        else if(oneTime>0)
        {
            image_2.sprite = timeNumber_0;
        }

        else if(oneTime>-1.0f)
        {
            oneTime=10;
        }

    }
}
