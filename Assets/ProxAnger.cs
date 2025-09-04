using UnityEngine;

public class ProxAnger : MonoBehaviour
{
    [SerializeField] public bool in_Range = false;
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player") || in_Range != true)
        {
            in_Range = true;
        } else { in_Range = false; }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
