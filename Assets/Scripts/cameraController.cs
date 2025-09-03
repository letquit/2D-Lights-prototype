using UnityEngine;

public class cameraController : MonoBehaviour
{
    public float moveSpeed = 5f; // 相机移动速度
    private Camera cam;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        // 获取WASD输入
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        
        // 计算移动方向
        Vector3 movement = new Vector3(horizontal, vertical, 0f).normalized;
        
        // 移动相机
        transform.position += movement * (moveSpeed * Time.deltaTime);
    }
}
