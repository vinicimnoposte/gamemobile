using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteTeste : MonoBehaviour
{

    public void OnMouseDown()
    {
       
        gameObject.SetActive(false);
        ScoreManager.instance.AddPoint();
    }
}
