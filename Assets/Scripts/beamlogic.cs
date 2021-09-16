using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beamlogic : MonoBehaviour
{
    public AudioClip shoot;
    private AudioSource sound;
    private bool faceright;

    // Start is called before the first frame update
    void Start()
    {
        faceright = countup1.faceright;
        sound = GetComponent<AudioSource>();
        sound.clip = shoot;
        sound.Play();
    }

    void Update()
    {

        if(faceright == true){
            transform.position += new Vector3(7, 0, 0); 
        }
        else{
            transform.position -= new Vector3(7, 0, 0); 
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "wall" || col.gameObject.tag == "leftwall" || col.gameObject.tag == "floor")
        {
            Destroy(gameObject);
        }
    }
}
