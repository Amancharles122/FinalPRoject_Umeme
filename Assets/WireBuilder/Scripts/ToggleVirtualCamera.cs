using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ToggleVirtualCamera : MonoBehaviour
{

    public GameObject vCam01, vCam02;
    public TMPro.TMP_Dropdown cameraAngleDD;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CameraSelector()
    {
        if (cameraAngleDD.value == 0) {
            vCam02.SetActive(false);
            vCam01.SetActive(true);
        } else if (cameraAngleDD.value == 1)
        {
            vCam02.SetActive(true);
            vCam01.SetActive(false);
        }
        
    }

    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
