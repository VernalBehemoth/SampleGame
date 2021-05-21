using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CharacterAnimation : MonoBehaviour
{
    private Animator _animator;
    private SpriteRenderer _spriteRenderer;
    
    private static readonly int Walking = Animator.StringToHash("Walking");

    /// <summary>
    /// Setup the cached variables
    /// </summary>
    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    /// <summary>
    /// Update - Generic animation stuff
    /// </summary>
    void Update()
    {
        var isMoving = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D);
        var flip = Input.GetKey(KeyCode.A);
        
        _animator.SetBool(Walking, isMoving);
        _spriteRenderer.flipX = flip;
    }
}
