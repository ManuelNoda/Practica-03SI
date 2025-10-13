using UnityEngine;

public class DetectorTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Un objeto ha entrado al Trigger: " + other.name);
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("El objeto sigue dentro del Trigger: " + other.name);
    }

    void OnTriggerExit(Collider other)
    {
        Debug.Log("El objeto ha salido del Trigger: " + other.name);
    }
}