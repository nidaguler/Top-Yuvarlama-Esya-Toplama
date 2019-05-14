using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour {

    Rigidbody fizik;
    public int hiz;
    int sayac = 0;
    public int toplanilacekObjeSayisi;
    public Text score;
    public Text gameOver;
	void Start ()
    {
        fizik = GetComponent<Rigidbody>();
	}
	
	
	void FixedUpdate ()
    {
        float dikey = Input.GetAxisRaw("Horizontal");
        float yatay = Input.GetAxisRaw("Vertical");
        Vector3 vec = new Vector3(yatay, 0, dikey);
        fizik.AddForce(vec*hiz);
	}


    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag=="engel")
        {
            other.gameObject.SetActive(false);
            sayac++;

            score.text = "Score: " + sayac;
            if (sayac == toplanilacekObjeSayisi)
            {
                gameOver.text = "Game Over";
            }
        }

        
        
    }

}
