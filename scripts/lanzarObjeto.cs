using UnityEngine;

public class lanzarObjeto : MonoBehaviour
{
    public float fuerzaLanzamiento = 400f;
    private Rigidbody rb;
    void Start()
    {
         rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            rb.AddForce(Vector3.up * fuerzaLanzamiento);
        }
    }
}
