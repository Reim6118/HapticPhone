
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.InputSystem;

[DefaultExecutionOrder(-1)]
public class TouchManager : Singleton<TouchManager>
{
    #region Events
    public delegate void StartTouch(Vector2 position, float time);
    public event StartTouch OnStartTouch;
    public delegate void EndTouch(Vector2 position, float time);
    public event StartTouch OnEndTouch;
    #endregion
    private InputTouch inputTouch;
    private Camera mainCamera;

    private void Awake()
    {
        inputTouch = new InputTouch();
        mainCamera = Camera.main;
    }
    private void OnEnable()
    {
        inputTouch.Enable();
    }
    private void OnDisable()
    {
        inputTouch.Disable(); 
    }
    void Start()
    {
        inputTouch.TouchInput.PrimaryContact.started += ctx => StartTouchPrimary(ctx);
        inputTouch.TouchInput.PrimaryContact.canceled += ctx => EndTouchPrimary(ctx);
    }
    private void StartTouchPrimary(InputAction.CallbackContext context)
    {
        //Debug.Log("Swipe start position:" + inputTouch.TouchInput.PrimaryPosition.ReadValue<Vector2>());
        if (OnStartTouch != null) OnStartTouch(Utils.ScreenToWorld(mainCamera,inputTouch.TouchInput.PrimaryPosition.ReadValue<Vector2>()),(float)context.startTime);

    }
    private void EndTouchPrimary(InputAction.CallbackContext context)
    {
        if (OnStartTouch != null) OnEndTouch(Utils.ScreenToWorld(mainCamera, inputTouch.TouchInput.PrimaryPosition.ReadValue<Vector2>()), (float)context.time);
    }
    public Vector2 PrimaryPosition()
    {
        return Utils.ScreenToWorld(mainCamera, inputTouch.TouchInput.PrimaryPosition.ReadValue<Vector2>());
    }

}
