using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 mousePosition;
    private Vector3 playerPosition;
    private Vector3 distanceBetweenMouseAndPlayer;

    private void OnMouseDown()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        distanceBetweenMouseAndPlayer = mousePosition - this.transform.position;
    }

    private void OnMouseDrag()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log("Player Position is "+ this.transform.position);
        this.transform.position = mousePosition - distanceBetweenMouseAndPlayer;
    }
}