using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCenario : MonoBehaviour
{
    public Vector3 spawnPos;

 
    public void Reseta()
    {
        //transform.position = spawnPos;
        //gameObject.transform.position = spawnPos;
        gameObject.transform.Translate(-spawnPos);
        Debug.Log("resetei");
    }
}
