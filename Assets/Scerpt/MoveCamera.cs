using UnityEngine;

public class moveCamera : MonoBehaviour
{
    [SerializeField] private float �ٶ� = 3.5f;
    [SerializeField] private float �����`���� = 100f;

    private float xRotation = 0f; // ӛ��������D�Ƕ�

    void Start()
    {
        // �i������K�[�أ��������[���� ESC ���i��
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // === �I�P�Ƅ� ===
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) //��ǰ forward z
        {
            transform.Translate(Vector3.forward * �ٶ� * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) //����
        {
            transform.Translate(Vector3.back * �ٶ� * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) //����
        {
            transform.Translate(Vector3.left * �ٶ� * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) //����
        {
            transform.Translate(Vector3.right * �ٶ� * Time.deltaTime);
        }

        // === �������D ===
        float mouseX = Input.GetAxis("Mouse X") * �����`���� * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * �����`���� * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // �������½Ƕȱ��ⷭ�D

        transform.localRotation = Quaternion.Euler(xRotation, transform.localEulerAngles.y + mouseX, 0f);
    }
}

