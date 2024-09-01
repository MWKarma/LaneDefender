using UnityEngine;

public class MovingBackground : MonoBehaviour
{
    [SerializeField] private float Speed;
    [SerializeField] private const float ScrollWidth = 17.8f;

    void Update()
    {
        Vector2 CurrentPosition = transform.position;

        CurrentPosition.x -= Speed * Time.deltaTime;

        if (transform.position.x < -ScrollWidth)
        {
            HandleOffScreen(ref CurrentPosition);
        }
        transform.position = CurrentPosition;
    }
    public virtual void HandleOffScreen(ref Vector2 pos)
    {
        pos += new Vector2(ScrollWidth * 2, 0);
    }
}
