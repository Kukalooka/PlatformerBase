using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class countup1 : MonoBehaviour
{
    public static int counter = 0; 

    public AudioClip step;

    private AudioSource sound;

    private int stepcounter = 0;

    public static bool moveable = true;

    public static bool faceright = false;
    private float higher = 1.5f;

    public GameObject beam;
    
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    void Update()
    {
        if ( Input.GetKey(KeyCode.UpArrow) == true)
        {
            if(collision.falling == false)
            {
                higher = 1.5f;
                counter = 0;
            }

            collision.falling = true;
        }

        if(collision.falling == true)
            {
                counter++;

                if(counter == 20 && Input.GetKey(KeyCode.UpArrow) == false){
                    counter = 40;
                }
                
                if(counter < 40 && higher < 8){
                    higher += 0.5f;
                }
                
                if(counter > 40 & higher > 0){
                    higher -= 0.5f;
                }

                transform.position += new Vector3(0, higher, 0); 
            }

        if ( Input.GetKey(KeyCode.RightArrow) == true )
        {
            if(moveable == true)
            {
                faceright = true;
                transform.position += new Vector3(5, 0, 0); 
            }

            if(collision.falling == false)
            {
                if (stepcounter < 1)
                {
                    sound.clip = step;
                    sound.Play();
                }
            }

            stepcounter++;

            if(stepcounter == 15)
            {
                stepcounter = 0;
            }
        }
        else if ( Input.GetKey(KeyCode.LeftArrow) == true )
        {
            if(moveable == true)
            {
                faceright = false;
                transform.position -= new Vector3(5, 0, 0); 
            }

            if(collision.falling == false)
            {
                if (stepcounter < 1)
                {
                    sound.clip = step;
                    sound.Play();
                }
            }


            stepcounter++;

            if(stepcounter == 15)
            {
                stepcounter = 0;
            }
        }

        if(Input.GetKeyDown(KeyCode.Z) == true)
        {
            Debug.Log("shot!");
            Instantiate(beam, transform.position, transform.rotation);
        }
    }
}
