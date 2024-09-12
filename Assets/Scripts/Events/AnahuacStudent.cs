using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnahuacStudent : MonoBehaviour
{
    private Image imagen;

    void Start()
    {
        imagen = GetComponent<Image>();
        EventManager.m_Instance.AddListener<Events>(MeVoyACasa);
        EventManager.m_Instance.AddListener<Events>(MeQuedoEnCasa);
    }


    public void MeVoyACasa(Event_NoLlegoElProfeEvent _event)
    {
        object[] parameters = _event.GetParameters();
        Debug.Log("Me voy a casa porque no llego el profe de" + parameters[0]);
        imagen.color = (Color)parameters[1];
    }
    private void MeQuedoEnCasa(Event_NoHayClase _event)
    {
        Debug.Log("Jugare minecraft");
    }
}


/*
private void Start()
{
    AddEventListener<Event_WinAnahuacRaffle>(WinRaffle);
}


public void WinRaffle(Event_WinAnahuacRaffle _event)
{
    Debug.Log("GANE UNA RIFA WAOS SOY MAESTRO");
}
*/