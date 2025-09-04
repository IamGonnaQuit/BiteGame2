using Unity.VisualScripting;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    public int damageAmount = 10; 
    public string targetTag = "Player"; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            BloodMeter bloodMeter = other.GetComponent<BloodMeter>();

            if (bloodMeter != null)
            {
                bloodMeter.DealingDamage(damageAmount);
            }
        }
    }
}
