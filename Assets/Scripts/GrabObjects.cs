using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabObjects : MonoBehaviour
{

    public GameObject gameObject;
    public Transform PosicionAgarre;
    public float range = 3f;
    public float Go = 100f;
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("Mouse1"))
        {
            Levantar();
        }

        if (Input.GetKeyUp("Mouse1"))
        {
            Soltar();
        }
    }

    void Levantar ()
    {
        RaycastHit hit;
        if (Physics.Raycast(camera.transform.position, camera.transform.forward, out hit, range))
          {
            Target target = hit.transform.GetComponent<Target>();
            if (target !=null)
            {
                PickUp();
            }
          }
    }

    void PickUp ()
    {
        gameObject.transform.SetParent(PosicionAgarre);
    }

    void Soltar ()
    {
        PosicionAgarre.DetachChildren();
    }
}
