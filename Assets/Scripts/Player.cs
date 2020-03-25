using UnityEngine;

public class Player : MonoBehaviour
{
    private void OnMouseDrag()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = -1;
        gameObject.transform.position = mousePosition;
    }
}