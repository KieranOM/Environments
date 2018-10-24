using UnityEngine;
using Vuforia;

public class Focus : MonoBehaviour {

    public void Start()
    {
        Debug.Log("Starting");
        CameraDevice.Instance.SetFocusMode(
        CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }
}
