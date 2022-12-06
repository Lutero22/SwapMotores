using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehavior : MonoBehaviour
{
    public float rangoDeDeteccion;

    public LayerMask capaDelJugador;
    public Transform Prisionero;
    public float Speed;

    bool Deteccion;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Deteccion = Physics.CheckSphere(transform.position, rangoDeDeteccion, capaDelJugador);

        if (Deteccion == true)
        {
            transform.LookAt(Prisionero);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, rangoDeDeteccion);
    }
}