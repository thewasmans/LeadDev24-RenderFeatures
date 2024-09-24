using UnityEngine;
using UnityEngine.Rendering.Universal;

public class OnPlayerEnter : MonoBehaviour
{
    private int m_index;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        var m_data = Camera.main.GetUniversalAdditionalCameraData();
        m_index++;
        m_index = m_index % 2;
        m_data.SetRenderer(m_index);

    }

}
