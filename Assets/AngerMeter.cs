using UnityEngine;
using TMPro;
public class AngerMeter : MonoBehaviour
{
    [SerializeField] private float angry_Points;
    [SerializeField] private float angry_Mod = 1.1f;
    [SerializeField] private float max_Angry = 50f;
    [SerializeField] private BloodMeter blood;
    //[SerializeField] private ProxAnger angry;
    [SerializeField] private float calm_Mod = 0.2f;
    [SerializeField] private SuckingBlood suck_anger;
    [SerializeField] private TMP_Text Meteranger;
    void Start()
    {
        blood = GetComponent<BloodMeter>();
        //angry = GetComponent<ProxAnger>();
        angry_Points = max_Angry / 4;
        suck_anger.GetComponent<SuckingBlood>();
    }

    // Update is called once per frame
    void Update()
    {
        if (suck_anger.Sucking)
        {
            angry_Points += 1 * angry_Mod * Time.deltaTime;
            Debug.Log("Anger going up");
        }
        else
        {
            angry_Points -= calm_Mod*Time.deltaTime;
            Debug.Log("Calming down");
        }
        if (angry_Points <= 0) { angry_Points = 10; }
        if (angry_Points == max_Angry)
        {
            blood.DealingDamage(max_Angry / 2);
            Debug.Log("Splat");
        }
        Meteranger.text = angry_Points.ToString("F1");
    }
}
