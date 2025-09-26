using UnityEngine;

public class moveCamera : MonoBehaviour
{
    [SerializeField] private float 速度 = 3.5f;
    [SerializeField] private float 滑鼠靈敏度 = 100f;

    private float xRotation = 0f; // 記錄上下旋轉角度

    void Start()
    {
        // 鎖定滑鼠並隱藏（可以在遊戲中 ESC 解鎖）
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // === 鍵盤移動 ===
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) //往前 forward z
        {
            transform.Translate(Vector3.forward * 速度 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) //往後
        {
            transform.Translate(Vector3.back * 速度 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) //往左
        {
            transform.Translate(Vector3.left * 速度 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) //往右
        {
            transform.Translate(Vector3.right * 速度 * Time.deltaTime);
        }

        // === 滑鼠旋轉 ===
        float mouseX = Input.GetAxis("Mouse X") * 滑鼠靈敏度 * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * 滑鼠靈敏度 * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // 限制上下角度避免翻轉

        transform.localRotation = Quaternion.Euler(xRotation, transform.localEulerAngles.y + mouseX, 0f);
    }
}

