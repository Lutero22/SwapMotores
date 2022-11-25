using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atacar : MonoBehaviour
{
    public float rangoDeDeteccion;

    public LayerMask capaDelJugador;
    public Transform Prisionero;

    bool Deteccion;

    Animator Anim;

    void Start()
    {
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Deteccion = Physics.CheckSphere(transform.position, rangoDeDeteccion, capaDelJugador);

        if (Deteccion == true)
        {
            Anim.SetBool("Golpeando", true);
        }

        else
        {
            Anim.SetBool("Golpeando", false);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, rangoDeDeteccion);
    }
}
