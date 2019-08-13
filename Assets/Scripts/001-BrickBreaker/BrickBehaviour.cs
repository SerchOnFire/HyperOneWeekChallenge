using UnityEngine;

public class BrickBehaviour : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public BoxCollider2D boxCollider;
    
    public void Reset()
    {
        SetValuesAs(true, true);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Ball")
        {
            SetValuesAs(false, false);
        }
    }
    
    void SetValuesAs(bool sprite, bool collider)
    {
        spriteRenderer.enabled = sprite;
        boxCollider.enabled = collider;
    }
}