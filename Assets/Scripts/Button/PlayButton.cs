
using UnityEngine;
using UnityEngine.Video;

public class PlayButton : MonoBehaviour
{
    [SerializeField]
    private VideoPlayer vidPlayer;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        vidPlayer.Play();
        StopButton.isPaused = false;
    }
}
