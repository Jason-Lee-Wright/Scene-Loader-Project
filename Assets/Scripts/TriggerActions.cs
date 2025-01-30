using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerActions : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.gameObject.CompareTag("Player"))
        {
            if (gameObject.CompareTag("left"))
            {
                ActionEvents.Goingleft.Invoke();
            }
            else if (gameObject.CompareTag("Right"))
            {
                ActionEvents.Goingright.Invoke();
            }
        }
    }
}

static class ActionEvents
{
    public static Action Goingleft;

    public static Action Goingright;
}