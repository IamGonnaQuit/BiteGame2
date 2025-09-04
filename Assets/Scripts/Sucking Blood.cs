using UnityEngine;

public class SuckingBlood : MonoBehaviour
{
    public bool Sucking = false;
    public bool Suckable = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Suckable) { 
            SuckingFunction();
        } else
        {
            Sucking = false;
        }
    }
    public void SuckingFunction()
    {
        if (Input.GetMouseButton(0))
        {
            Sucking = true;
            Debug.Log("You are currently sucking");
        } else
        {
            Sucking = false;
        }
    }
}
