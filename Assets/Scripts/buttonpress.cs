using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class buttonpress : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool buttonPressed;
    
    public void OnPointerDown(PointerEventData eventData){
        buttonPressed = true;
        SceneManager.LoadScene (sceneName:"Troll");
        Debug.Log("press");
    }
    
    public void OnPointerUp(PointerEventData eventData){
        buttonPressed = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
