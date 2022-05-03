using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ControlaTimer : MonoBehaviour
{
    Image timerBar;
    public float maxTime = 15f;
    public float timeLeft;
    public bool podeContar;
    //public GameObject timesUpText;
    // Start is called before the first frame update
    void Start()
    {
        //timesUpText.SetActive (false);
        timerBar = GetComponent<Image>();
        timeLeft = maxTime;
        podeContar = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeLeft > 0 && podeContar == true)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
        }
        else if (timeLeft > 0 && FindObjectOfType<ControlaAnim>().lose == true)
        {
            GameObject.FindObjectOfType<LoseAnim>().LoseRound();
            
            
        }
        if(FindObjectOfType<ControlaAnim>().win == true)
        {

            podeContar = false;

        }
        else
        {
            podeContar = true;
        }
        if (timeLeft <= 0)
        {
            GameObject.FindObjectOfType<LoseAnim>().LoseRound();
        }
        if (FindObjectOfType<ControlaAnim>().win == true)
        {
            maxTime = 6f;
        }


    }
}
