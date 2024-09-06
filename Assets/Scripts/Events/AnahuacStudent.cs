using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnahuacStudent : GameMonoBehaviour
{

    private void Start()
    {
        AddEventListener<Event_WinAnahuacRaffle>(WinRaffle);
    }

    
    public void WinRaffle(Event_WinAnahuacRaffle _event)
    {
        Debug.Log("GANE UNA RIFA WAOS SOY MAESTRO");
    }
}
