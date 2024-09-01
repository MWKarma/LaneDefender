using UnityEngine;

public class MovingBackground : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private const float _scrollWidth = 17.8f;
    //determines on how long it the background is

    void Update()
    {
        Vector2 CurrentPosition = transform.position;

        CurrentPosition.x -= _speed * Time.deltaTime;

        if (transform.position.x < -_scrollWidth)
        {
            HandleOffScreen(ref CurrentPosition);
        }
        transform.position = CurrentPosition;
        //if background1 has gone off screen it will then move in front of background2, the same goes for bg2
    }
    public virtual void HandleOffScreen(ref Vector2 pos)
    {
        pos += new Vector2(_scrollWidth * 2, 0);
    }
}
