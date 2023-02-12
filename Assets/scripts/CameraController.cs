using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerTransform;
    public float smoothing = 5f;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - playerTransform.position;
    }

    void FixedUpdate()
    {
        Vector3 targetCamPos = playerTransform.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}
