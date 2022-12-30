using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public GameObject ExpObj;

    private void OnTriggerEnter(Collider other)
    {
        ExpObj.SerActive(true);
        transform.GetComponent<MeshRenderer>().enabled = false;
        invoke("DestObj", 2);
    }

    void DesyObj()
    {
        Destroy(this.gameObject);
    }
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
