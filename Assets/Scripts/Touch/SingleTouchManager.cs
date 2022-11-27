
using UnityEngine;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class SingleTouchManager : Singleton<TouchManager>
{
    #region Events
    public delegate void StartTouchEvent(Vector2 position, float time);
    public event StartTouchEvent OnStartTouch;
    public delegate void EndTouchEvent(Vector2 position, float time);
    public event StartTouchEvent OnEndTouch;
    #endregion
    private SingleTouch singleTouch;
    private Camera mainCamera;

    private void Awake()
    {
        singleTouch = new SingleTouch();
        
    }
    private void OnEnable()
    {
        singleTouch.Enable();
    }
    private void OnDisable()
    {
        singleTouch.Disable();
    }
    void Start()
    {
        singleTouch.Touch.TouchPress.started += ctx => StartTouch(ctx);
        singleTouch.Touch.TouchPress.started += ctx => EndTouch(ctx);
    }
    private void StartTouch(InputAction.CallbackContext context)
    {
        Debug.Log("Touch Strated:" + singleTouch.Touch.TouchPosition.ReadValue<Vector2>());
    }
    private void EndTouch(InputAction.CallbackContext context)
    {
        Debug.Log("Touch Ended:" + singleTouch.Touch.TouchPosition.ReadValue<Vector2>());
    }
    

}

