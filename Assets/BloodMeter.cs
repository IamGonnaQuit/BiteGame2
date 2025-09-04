using UnityEngine;
using UnityEngine.Rendering;

public class BloodMeter : MonoBehaviour
{
    [SerializeField] private float points; 
    [SerializeField] private float zone_Modifier = 1f;
    //[SerializeField] private float max_Points = 200f;
    public bool Sucking = false;
    void Start()
    {
        points = 20f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Sucking)
        {
            points = 0.2f * zone_Modifier * Time.deltaTime/2;
            Debug.Log("Sucking");
            Debug.Log(points);
        }
        if (points <= 0)
        {
            Debug.Log("Splat");
        }
    }
    public void DealingDamage(float dmg)
    {
        points -= dmg;
    }
}
