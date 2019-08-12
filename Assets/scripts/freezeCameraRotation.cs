using UnityEngine;

public class freezeCameraRotation : MonoBehaviour
{
    Camera cam;
    private void Start()
    {
        cam = this.GetComponent<Camera>();
    }
    private void Update()
    {
        cam.transform.rotation = Quaternion.Euler(0, cam.transform.position.y, 0);
    }
}
