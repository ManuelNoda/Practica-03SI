using UnityEngine;

public class Cambiopersonaje : MonoBehaviour
{
    [Header("Light Zone")]
    public Light sceneLight;                  // La luz que quieres modificar
    public Color zoneLightColor = Color.red;  // Color al entrar en la zona
    private Color originalLightColor;
    private float originalIntensity;

    [Header("Damage Zone")]
    public int damageIncrease = 10;
    public int playerDamage = 0;

    void Start()
    {
        if (sceneLight != null)
        {
            originalLightColor = sceneLight.color;
            originalIntensity = sceneLight.intensity;
        }
        else
        {
            Debug.LogWarning("No se ha asignado ninguna luz a sceneLight");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Zona de luz
        if (other.CompareTag("CambioColor") && sceneLight != null)
        {
            sceneLight.color = zoneLightColor;
            sceneLight.intensity = originalIntensity * 2f; // aumenta intensidad
        }

        // Zona de daño
        if (other.CompareTag("zonaDaño"))
        {
            playerDamage += damageIncrease;
            Debug.Log("Daño aumentado: " + playerDamage);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Revertir cambios de luz al salir
        if (other.CompareTag("CambioColor") && sceneLight != null)
        {
            sceneLight.color = originalLightColor;
            sceneLight.intensity = originalIntensity;
        }

    }
}
