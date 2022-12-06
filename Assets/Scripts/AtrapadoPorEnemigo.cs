using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AtrapadoPorEnemigo : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemigo"))
        {
            Debug.Log("Jugador atrapado");
            SceneManager.LoadScene("Derrota");
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
        }
        if (other.CompareTag("Salida"))
        {
            Debug.Log("Jugador Escapo");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
        }
    }
}
