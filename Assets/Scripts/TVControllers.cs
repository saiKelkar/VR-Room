using UnityEngine;
using UnityEngine.Video;

public class TVController : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Assign the Video Player in the Inspector

    public void PlayVideo()
    {
        if (videoPlayer != null)
        {
            videoPlayer.Play();
        }
    }

    public void PauseVideo()
    {
        if (videoPlayer != null)
        {
            videoPlayer.Pause();
        }
    }

    public void StopVideo()
    {
        if (videoPlayer != null)
        {
            videoPlayer.Stop();
        }
    }

    public void NextVideo()
    {
        if (videoPlayer != null && videoPlayer.clip != null)
        {
            // Logic to switch to the next video, assuming you have multiple video clips
            videoPlayer.clip = GetNextVideoClip();
            videoPlayer.Play();
        }
    }

    private VideoClip GetNextVideoClip()
    {
        // Add logic to cycle through available videos
        return null; // Replace with your video management system
    }
}
