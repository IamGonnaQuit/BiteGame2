using UnityEngine;

public class SuckingBlood : MonoBehaviour
{
    public bool Sucking = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Sucking = true;
        } else
        {
            Sucking = false;
        }
        if (Sucking)
        {
            SuckingFunction();
            Debug.Log("We are sucking baby");
        }
        else
        {
            Debug.Log("We aren't sucking man");
        }
    }
    public void SuckingFunction()
    {
        Sucking = true;
    }
}
