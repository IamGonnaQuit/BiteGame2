using Unity.VisualScripting;
using UnityEngine;

public class Hazard : MonoBehaviour
{
    public int damageAmount = 10; 
    //public string targetTag = "Player"; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        
            BloodMeter dmg = other.GetComponent<BloodMeter>();

            if (dmg != null)
            {
                dmg.DealingDamage(damageAmount);
            }
        
    }
}
