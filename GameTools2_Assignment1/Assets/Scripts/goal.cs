using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goal : MonoBehaviour {

    public GameObject m_winText;

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Instantiate(m_winText);
        }
    }
}
