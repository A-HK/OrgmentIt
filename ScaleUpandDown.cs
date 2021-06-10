using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleUpandDown : MonoBehaviour
{
    //public float scalingspeed = 100f;
    public float scalingspeed = 5f;//(0* (Time.deltaTime));
    bool ScaleUp = false;
    bool ScaleDown = false;

    Vector3 temp;

    // Update is called once per frame
    void Update()
    {
        if (ScaleUp == true)
            ScaleUpButton();
        if (ScaleDown == true)
            ScaleDownButton();
    }

    public void ScaleUpButton()
    {
        temp = GameObject.FindWithTag("KidneyModel").transform.localScale;
        temp += new Vector3(scalingspeed, scalingspeed, scalingspeed);
        GameObject.FindWithTag("KidneyModel").transform.localScale = temp;
        // GameObject.FindWithTag("KidneyModel").transform.localScale += new Vector3(scalingspeed, scalingspeed, scalingspeed);
    }
    public void ScaleDownButton()
    {
        GameObject.FindWithTag("KidneyModel").transform.localScale += new Vector3(-scalingspeed, -scalingspeed, -scalingspeed);
    }

    public void Up()
    {
        ScaleUp = true;
        ScaleDown = false;
    }
    public void Down()
    {
        ScaleUp = false;
        ScaleDown = true;
    }
    public void Stop()
    {
        ScaleUp = false;
        ScaleDown = false;
    }
}
