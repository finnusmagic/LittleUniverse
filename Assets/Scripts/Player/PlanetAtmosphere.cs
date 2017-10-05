using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetAtmosphere : MonoBehaviour {

    GravityBody gravityBody;

    Rigidbody body;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gravityBody = other.gameObject.GetComponent<GravityBody>();
            gravityBody.planet = transform.parent.GetComponent<GravityAttractor>();
            body = other.gameObject.GetComponent<Rigidbody>();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        gravityBody.planet = null;
    }
}
