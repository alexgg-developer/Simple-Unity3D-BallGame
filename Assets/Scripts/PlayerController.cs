using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float m_speed = 100;
    [SerializeField]
    private Text m_countText = null;
    private Rigidbody m_rigidbody = null;
    private int m_count = 0;
    // Use this for initialization
    private Vector3 JUMP_FORCE = new Vector3(0.0f, 360.0f, 0.0f);
    void Start()
    {
        m_rigidbody = GetComponent<Rigidbody>();
        m_speed = 100;
        CountText();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        if (Input.GetKeyDown(KeyCode.Space)) {
            movement.y = 180.0f;
        }
        m_rigidbody.AddForce(movement * m_speed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item")) {
            other.gameObject.SetActive(false);
            ++m_count;
            CountText();
        }
        if (other.gameObject.CompareTag("Hazard")) {
            other.gameObject.SetActive(false);
            var force = JUMP_FORCE * m_speed * Time.deltaTime;
            m_rigidbody.AddForce(JUMP_FORCE * m_speed * Time.deltaTime);
        }

    }

    void CountText()
    {
        m_countText.text = "Count: " + m_count.ToString();
    }
}
