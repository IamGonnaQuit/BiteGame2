using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

public class MosquitoMovement : MonoBehaviour
{
    [SerializeField]
    private Vector3 mousePosition;
    [SerializeField]
    private float mosquitoSpeed;
    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        mousePosition.z = 0;
        transform.position = Vector2.Lerp(transform.position, mousePosition, mosquitoSpeed);
    }
}
