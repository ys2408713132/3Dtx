using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField] private float �ٶ� = 3.5f;
    public float rotationSpeed = 5f; // ���D�ٶȱ���
    public bool lockY = true;        // �Ƿ��i�� Y �S

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * �ٶ� * Time.deltaTime);

        //�����ƄӽǶ�
        float mouseX = Input.GetAxis("Mouse X"); // ���������Ƅ�
        float mouseY = Input.GetAxis("Mouse Y"); // ���������Ƅ�

        if (lockY)
        {
            // ֻ�� X �S�����D Y �S���������D�ӣ�
            transform.Rotate(Vector3.up, mouseX * rotationSpeed, Space.World);
        }
        else
        {
            // ʹ�� X, Y ͬ�r���D
            transform.Rotate(Vector3.up, mouseX * rotationSpeed, Space.World);
            transform.Rotate(Vector3.right, mouseY * rotationSpeed, Space.World);
        }


        //λ�� 
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
    }
}
