using UnityEngine;

public class Rotator : MonoBehaviour
{
    private Vector3 m_rotation = new Vector3(15, 30, 45);
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(m_rotation * Time.deltaTime);
    }
}
