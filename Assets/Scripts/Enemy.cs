using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Speed")]
    [SerializeField] private float _movementSpeed = 0f;
    [SerializeField] private float _rotationSpeed = 0f;

    [Header("Speed")]
    [SerializeField] private GameObject _targetToFollow = null;
    [SerializeField] private float _increaseScaleTarget = 0f;
    private Vector3 _scaleSizeVector;
    public Vector3 ScaleSizeVector => _scaleSizeVector;
    private Vector3 directionToMove;

    private void Start()
    {
        _scaleSizeVector = new Vector3(_increaseScaleTarget, _increaseScaleTarget);
    }

    private void OnTriggerStay2D()
    {
        directionToMove = _targetToFollow.transform.position - this.transform.position;
        
        Debug.DrawRay(this.transform.position, this.transform.up*2, Color.blue, 20);
        Debug.DrawRay(this.transform.position, directionToMove, Color.red, 20);
        
        float angleBetweenEnemyAndTarget = Vector3.SignedAngle(this.transform.up, directionToMove, this.transform.forward);

        this.transform.Rotate(0, 0 , (angleBetweenEnemyAndTarget * _rotationSpeed));
        this.transform.Translate(this.transform.up * _movementSpeed * Time.deltaTime, Space.World);
    }
}