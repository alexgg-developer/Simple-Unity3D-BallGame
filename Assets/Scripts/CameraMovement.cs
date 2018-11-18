using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    private GameObject m_player = null;
    private Vector3 m_offset;
    // Use this for initialization
    void Start()
    {
        m_offset = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = m_player.transform.position + m_offset;
    }
}
