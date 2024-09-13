using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnahuacTeacher : MonoBehaviour
    
{
    private Image imagen;

    
    void Start()
    {
        EventManager.m_Instance.AddListener<Event_NoLlegoElProfeEvent>(MeVoyACasa);
        
    }

    // Update is called once per frame
    public void MeVoyACasa(Event_NoLlegoElProfeEvent _event)
    {
        object[] parameters = _event.GetParameters();
        Debug.Log("Me voy a casa");
    }
}
