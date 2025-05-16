using TMPro;
using UnityEngine;

public class TilesScript : MonoBehaviour
{
    public Vector2 targetPosition;
    private Vector2 correctPosition;
    private SpriteRenderer _sprite; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        targetPosition = transform.position;
        correctPosition = transform.position;
        _sprite = GetComponent<SpriteRenderer>(); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.Lerp(transform.position, targetPosition, 0.05f);
        if (targetPosition == correctPosition )
        {
            _sprite.color = Color.green;
        }
        else
        {
            _sprite.color = Color.white;
        }
    }
}
