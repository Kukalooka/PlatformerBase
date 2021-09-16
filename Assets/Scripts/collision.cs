using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collision : MonoBehaviour
{
    public static bool falling = true;

    public AudioClip land;

    private AudioSource sound;

    public float fall = 0.5f;

    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    void Update()
    {
        if(falling == true){
            if(fall < 4){
                fall += 0.25f;
            }
            transform.position -= new Vector3(0, fall, 0); 
        }
        else{
            fall = 0;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Collision");
        if (col.gameObject.tag == "floor")
        {
            Debug.Log("Collision");
            if(falling == true){
                sound.clip = land;
                sound.Play();
            }
            falling = false;
            fall = 0;
        }
    }

    void OnCollisionStay(Collision col){
        if (col.gameObject.tag == "wall")
        {
            transform.position += new Vector3(4, 0, 0); 

            countup1.moveable = false;
        }

        if(col.gameObject.tag == "leftwall")
        {
            transform.position -= new Vector3(4, 0, 0); 

            countup1.moveable = false;
        }
    }

    void OnCollisionExit(Collision col)
    {
        if(col.gameObject.tag  == "floor")
        {
            falling = true;
        }

        if (col.gameObject.tag == "wall")
        {
            countup1.moveable = true;
        }

        if (col.gameObject.tag == "leftwall")
        {
            countup1.moveable = true;
        }
    }
}