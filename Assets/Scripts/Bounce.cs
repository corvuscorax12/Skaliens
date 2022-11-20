using Unity.Mathematics;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D character;
    void Start()
    {

    }
    private void Update()
    {
        int time = Time.frameCount % 120;

        if (character.position.y < -5.09)
        {
            character.constraints = RigidbodyConstraints2D.FreezePosition;
            if (time == 0 )
            {
                var vec = new Vector2(-3, 10);
                character.velocity = vec;
                character.constraints = RigidbodyConstraints2D.None;

            }
        }
        else
        {
            character.constraints = RigidbodyConstraints2D.None;
        }
    }



}
