using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyobjectOnColission : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GameObject.Destroy(gameObject);
    }
}
