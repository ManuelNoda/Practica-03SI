using UnityEngine;

public class cambiocolor : MonoBehaviour
{
  
    private Color GenerateRandomColor()
    {
        return new Color(
            Random.Range(0f, 1f),
            Random.Range(0f, 1f),
            Random.Range(0f, 1f)
        );
    }

   private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("cubo"))
        {
            Debug.Log("Colisioné con: " + collision.gameObject.tag);
            Renderer rend = collision.gameObject.GetComponent<Renderer>(); 

            if(rend != null)
            {
                rend.material.color = GenerateRandomColor();
            }
        }
    }
}
