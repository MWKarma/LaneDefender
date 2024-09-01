using UnityEngine;

public class Bullets : MonoBehaviour
{
    [SerializeField] private float _speed = 4.5f;
    [SerializeField] private float _maxLifeTime = 4.0f;

    private void Start()
    {
        Destroy(this.gameObject, this._maxLifeTime);
    }
    private void Update()
    {
        transform.position += transform.right * Time.deltaTime * _speed;
        //Checks where the bullet spawner is then shoots a bullet faceing right and makes it go right
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
