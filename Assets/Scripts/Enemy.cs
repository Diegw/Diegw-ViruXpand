using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _movementSpeed = 0f;
    [SerializeField] private float _rotationSpeed = 0f;
    [SerializeField] private float _increaseScaleSize = 0f;
    [SerializeField] private GameObject _target = null;
    private Vector3 _scaleSizeVector;

    private void Start()
    {
        _scaleSizeVector = new Vector3(_increaseScaleSize, _increaseScaleSize);

    }

    private void OnTriggerStay2D()
    {
        Vector3 currentPosition = this.transform.position;
        Vector3 targetPosition = _target.transform.position;
        Vector3 directionToMove = targetPosition - currentPosition;
        
        //Debug.DrawRay(currentPosition, this.transform.up*5, Color.blue, 20);
        //Debug.DrawRay(currentPosition, directionToMove, Color.red, 20);
        
        float angleBetweenEnemyAndTarget = Vector3.SignedAngle(this.transform.up, directionToMove, this.transform.forward);
        this.transform.Rotate(0, 0 , (angleBetweenEnemyAndTarget * _rotationSpeed));

        this.transform.Translate(this.transform.up * _movementSpeed * Time.deltaTime, Space.World);
    }

    // private void OnTriggerEnter2D(Collider2D objectCollideWith)
    // {
    //     Debug.Log("Collision Enter");
    //     Transform transform = objectCollideWith.GetComponent<Transform>();
    //     transform.localScale += scaleSizeVector;
    //     Destroy(gameObject);
    // }
}