using UnityEngine;

public class CheckPosMosquito : MonoBehaviour
{
    [SerializeField]
    private SuckingBlood SuckingBlood;
    private void OnTriggerEnter2D(Collider2D other)
    {
        SuckingBlood.Sucking = true;
        Debug.Log("They are within sucking range");
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        SuckingBlood.Sucking = false;
        Debug.Log("They are out of sucking range");
    }
}
