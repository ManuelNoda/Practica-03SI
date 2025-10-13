using UnityEngine;

public class recolectar : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("personaje"))
        {
            Debug.Log("Objeto recolectado");
            Destroy(gameObject);
        }
    }
}
