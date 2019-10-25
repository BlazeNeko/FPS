﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class DeathPlane : MonoBehaviour
{
    /// <summary>
    /// El jugador
    /// </summary>
    public GameObject m_Player = null;

    /// <summary>
    /// Game Manager para hacer respawn del jugador
    /// </summary>
    private GameObject m_GameManager = null;

    /// <summary>
    /// En la función Start hacemos una búsqueda del GameManager
    /// </summary>
    void Start()
    {

        // TODO 1 - Buscamos un GameObject cuyo tag sea "GameManager"
        m_GameManager = GameObject.FindGameObjectWithTag("GameManager");
    }


    /// <summary>
    /// Si algo choca contra nosotros, comprobaremos si es el player
    /// </summary>
    /// <param name="other">
    /// Objeto que ha entrado en el trigger <see cref="Collider"/>
    /// </param>
    void OnTriggerEnter(Collider other)
    {
        // TODO 2 - Comprobamos que el transform del objeto que colisiona, es el player
        if (other.gameObject.CompareTag("Player"))
        {
            // TODO 3 - Enviamos un mensaje al GameManager llamando a la función "RespawnPlayer"
            m_GameManager.SendMessage("RespawnPlayer", SendMessageOptions.DontRequireReceiver);
        }
    }
}
