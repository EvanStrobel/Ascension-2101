using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invisibility : MonoBehaviour
{
    public Renderer rend;
    public float timer=0.0f;
    private float duration=5.0f;
    private float reset=0.0f;
    public bool CanUse=true;
    private bool TimerRunning = false;
    public bool OnCooldown=false;
    private float CooldownTime = 10.0f;


    // 
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }
    


    // Toggle the Object's visibility each second.
    void Update()
    {
        invisibility();

        if (TimerRunning == true)
        {
            timer += Time.deltaTime;
            if (timer > duration)
            {   
                timer = reset;
                rend.enabled = true;
                OnCooldown = true;
                TimerRunning = false;
            }
        }

        if (OnCooldown == true)
        {
            timer += Time.deltaTime;
            if (timer >= CooldownTime)
            {
                OnCooldown = false;
                timer = reset;
            }
        }
    }

    void invisibility()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            // check if something is stopping invisibility
            if (CanUse == true)
            {
                // See if ability is currently on cooldown
                if (OnCooldown == false)
                {
                    // activate duration timer and enable invisibility
                    TimerRunning = true;
                    rend.enabled = false;
                }
            }
        }

    }
}
