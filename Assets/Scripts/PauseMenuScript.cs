using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public static bool Pausa = false;
    public GameObject CanvasPausa;

    void Start()
    {
        Time.timeScale = 1f;
    }

    void Update()
    {
      if(Input.GetKeyDown(KeyCode.P))
        {
            if(Pausa)
            {
                Play();
            }
            else
            {
                Stop();
            }
        }
    }

    void Stop()
    {
        CanvasPausa.SetActive(true);
            Time.timeScale = 0f;
        Pausa = true;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }

    public void Play()
    {
        CanvasPausa.SetActive(false);
            Time.timeScale = 1f;
        Pausa = false;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void MenuButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
