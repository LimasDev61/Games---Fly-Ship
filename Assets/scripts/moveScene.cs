using System.Runtime.CompilerServices;
using Unity.Mathematics;
using UnityEngine;

public class moveScene : MonoBehaviour

{
    public float scrollSpeed = 1f;
    private Vector2 startOffset;

    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        startOffset = spriteRenderer.material.mainTextureOffset;
    }

    void Update()
    {
        float newOffset = Mathf.Repeat(Time.time * scrollSpeed, 1);
        spriteRenderer.material.mainTextureOffset = startOffset + new Vector2(newOffset, 0);
    }

    private void OnDisable()
    {
        if (spriteRenderer != null && spriteRenderer.material.mainTextureOffset != null)
        {
            spriteRenderer.material.mainTextureOffset = startOffset;
        }
    }
}
