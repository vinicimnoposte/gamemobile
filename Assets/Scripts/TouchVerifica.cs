using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchVerifica : MonoBehaviour
{
    public GameObject menu;
    public GameObject[] inimigos;
    void Update()
    {
        if (menu.activeInHierarchy)
        {
            foreach (GameObject inimigo in inimigos)
            {
                inimigo.GetComponent<CapsuleCollider>().enabled = false;


            }
        }
        else
        {
            foreach (GameObject inimigo in inimigos)
            {
                inimigo.GetComponent<CapsuleCollider>().enabled = true;
            }
        }
    }
}
