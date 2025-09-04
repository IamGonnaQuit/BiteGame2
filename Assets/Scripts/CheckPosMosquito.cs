using UnityEngine;

public class CheckPosMosquito : MonoBehaviour
{
    [SerializeField]
    private SuckingBlood SuckingBlood;
    private void OnTriggerEnter2D(Collider2D other)
    {
        SuckingBlood.Suckable = true;
        Debug.Log("They are within sucking range");
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        SuckingBlood.Suckable = false;
        Debug.Log("They are out of sucking range");
    }
}
