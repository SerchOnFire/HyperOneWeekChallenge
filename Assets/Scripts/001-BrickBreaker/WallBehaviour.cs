using UnityEngine;

public class WallBehaviour : MonoBehaviour
{
    private BrickBehaviour[] bricks;
    void Awake ()
    {
        bricks = transform.GetComponentsInChildren<BrickBehaviour>();
    }

    public void Reset()
    {
        for (int i = 0, iEnd = bricks.Length;  i < iEnd; i++)
            bricks[i].Reset(); 
    }
}
