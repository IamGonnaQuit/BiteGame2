using UnityEngine;

public class AngerMeter : MonoBehaviour
{
    [SerializeField] private float angry_Points;
    [SerializeField] private float angry_Mod = 1.1f;
    [SerializeField] private float max_Angry = 100f;
    [SerializeField] private BloodMeter blood;
    void Start()
    {
        blood = GetComponent<BloodMeter>();
        angry_Points = max_Angry / 4;
    }

    // Update is called once per frame
    void Update()
    {
        if (blood.Sucking)
        {
            angry_Points = 1 * angry_Mod * Time.deltaTime;
        }
    }
}
