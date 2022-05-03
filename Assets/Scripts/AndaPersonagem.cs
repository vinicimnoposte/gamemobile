using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AndaPersonagem : MonoBehaviour
{
    public bool anda;
    // Start is called before the first frame update 
    void Start()
    {

    }

    // Update is called once per frame 
    void Update()
    {
        if (anda == true)
        {
            transform.Translate(new Vector3(0, 0, -4) * Time.deltaTime);
        }

    }
}
