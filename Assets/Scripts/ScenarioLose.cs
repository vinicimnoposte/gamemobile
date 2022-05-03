using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenarioLose : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (FindObjectOfType<ControlaMenu>().menu.activeInHierarchy == false)
        {
            FindObjectOfType<LoseAnim>().LoseRound();
        }
    }
}
