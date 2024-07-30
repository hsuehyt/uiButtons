using UnityEngine;

public class CubeController : MonoBehaviour
{
    public GameObject cube;

    void Start()
    {
        // Hide the cube at the start
        cube.SetActive(false);
    }

    public void ToggleCube()
    {
        // Toggle the cube's active state
        cube.SetActive(!cube.activeSelf);
    }
}
