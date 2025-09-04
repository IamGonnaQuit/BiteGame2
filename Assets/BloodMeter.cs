using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class BloodMeter : MonoBehaviour
{
    [SerializeField] private float points; 
    [SerializeField] private float zone_Modifier = 1.1f;
    [SerializeField] private float max_Points = 200f;
    [SerializeField] private SuckingBlood suck;
    void Start()
    {
        points = 20f;
        suck.GetComponent<SuckingBlood>();
    }

    // Update is called once per frame
    void Update()
    {
        if (suck.Sucking)
        {
            points += 1f * zone_Modifier * Time.deltaTime;
            Debug.Log("Sucking");
            Debug.Log(points);
        }
        if (points <= 0)
        {
            Debug.Log("Splat");
            SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
        }
    }
    public void DealingDamage(float dmg)
    {
        points -= dmg;
    }
}
