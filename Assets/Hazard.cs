using UnityEngine;

public class Hazard : MonoBehaviour
{
    public int damageAmount = 10;
    public bool isActive = true;   // hazard starts active by default
    [SerializeField] private float minTime = 3f;
    [SerializeField] private float maxTime = 4f;
    [SerializeField] private Sprite fan1;
    [SerializeField] private Sprite fan2;
    [SerializeField] private SpriteRenderer sprite;
    private void Start()
    {
        StartCoroutine(ToggleRoutine());
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!isActive) return; // do nothing if hazard is "off"

        BloodMeter dmg = other.GetComponent<BloodMeter>();
        if (dmg != null)
        {
            dmg.DealingDamage(damageAmount); // make sure your BloodMeter has this method
        }
    }

    private System.Collections.IEnumerator ToggleRoutine()
    {
        while (true)
        {
            // flip active state
            isActive = !isActive;

            // (optional) make the object visually disappear when inactive
            gameObject.GetComponent<SpriteRenderer>().enabled = isActive;

            // wait random 3–4 seconds
            float waitTime = Random.Range(minTime, maxTime);
            yield return new WaitForSeconds(waitTime);
            if (waitTime < 2)
            {
                if (sprite.sprite = fan2) { sprite.sprite = fan1;}
                if (sprite.sprite = fan1) { sprite.sprite = fan2;}
            }
        }
    }
}
