using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleDirector : MonoBehaviour
{
    void ScenTransition()
    {
        SceneManager.LoadScene("SelectScene");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("joystick button 0"))
        {
            ScenTransition();
        }
        if (Input.GetKeyDown("joystick button 1"))
        {
            ScenTransition();
        }
        if (Input.GetKeyDown("joystick button 2"))
        {
            ScenTransition();
        }
        if (Input.GetKeyDown("joystick button 3"))
        {
            ScenTransition();
        }
        if (Input.GetKeyDown("joystick button 4"))
        {
            ScenTransition();
        }
        if (Input.GetKeyDown("joystick button 5"))
        {
            ScenTransition();
        }
        if (Input.GetKeyDown("joystick button 6"))
        {
            ScenTransition();
        }
        if (Input.GetKeyDown("joystick button 7"))
        {
            ScenTransition();
        }
        if (Input.GetKeyDown("joystick button 8"))
        {
            ScenTransition();
        }
        if (Input.GetKeyDown("joystick button 9"))
        {
            ScenTransition();
        }
        if (Input.GetKeyDown("joystick button 10"))
        {
            ScenTransition();
        }
        if (Input.GetKeyDown("joystick button 11"))
        {
            ScenTransition();
        }
    }
}
