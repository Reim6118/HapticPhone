using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeDetection : MonoBehaviour
{
    /*[SerializeField]
    private float minimumDistance = .2f;
    [SerializeField]
    private float maximumTime = 1f;*/
    [SerializeField]
    public GameObject trail;

    private Coroutine coroutine;
    private TouchManager touchManager;

    private Vector2 startPosition;
    private float startTime;
    private Vector2 endPosition;
    private float endTime;
    private void Awake()
    {
        touchManager = TouchManager.Instance;
    }
    private void OnEnable()
    {
        touchManager.OnStartTouch += SwipeStart;
        touchManager.OnEndTouch += SwipeEnd;
    }
    private void OnDisable()
    {
        touchManager.OnStartTouch -= SwipeStart;
        touchManager.OnEndTouch -= SwipeEnd;
    }
    private void SwipeStart(Vector2 position, float time)
    {
        startPosition = position;
        startTime = time;
        trail.SetActive(true);
        trail.transform.position = position;
        coroutine = StartCoroutine(Trail());
    }

    private IEnumerator Trail()
    {
        while (true)
        {
            trail.transform.position = touchManager.PrimaryPosition();
            yield return null;
        }
    }

    private void SwipeEnd(Vector2 position, float time)
    {
        trail.SetActive(false);
        StopCoroutine(coroutine);
        endPosition = position; 
        endTime = time;
        //Debug.Log("calling detect swipe");
        //DetectSwipe();
    }
    /*private void DetectSwipe()
    {
       // Debug.DrawLine(startPosition, endPosition, Color.red, 5f);
        //Debug.Log("In swipe if, start end distance:" + startPosition+endPosition);

        if (Vector3.Distance(startPosition, endPosition) >= minimumDistance && (endTime-startTime)<=maximumTime)
        {
            //Debug.Log("In swipe if");
            Debug.DrawLine(startPosition, endPosition,Color.red, 5f);

        }
    }*/
}
