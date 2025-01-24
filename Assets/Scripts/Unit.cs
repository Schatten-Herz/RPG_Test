using UnityEngine;

public class Unit : MonoBehaviour
{
    private Vector3 _targetPosition;

    private void Start()
    {
        _targetPosition = transform.position; // 初始化目标位置为当前位置
    }
    
    private void Update()
    {
        float stoppingDistance = 0.1f;
        if (Vector3.Distance(transform.position, _targetPosition) > stoppingDistance) //到达目标距离停止
        {
             Vector3 moveDirection = (_targetPosition - transform.position).normalized;
                    float moveSpeed = 4f;
                    transform.position += moveDirection * (Time.deltaTime * moveSpeed);
        }
        
        if (Input.GetKeyDown(KeyCode.T))
        {
            Move(new Vector3(4,0,4));
        }
    }

    private void Move(Vector3 targetPosition)
    {
        this._targetPosition = targetPosition;
    }
}
