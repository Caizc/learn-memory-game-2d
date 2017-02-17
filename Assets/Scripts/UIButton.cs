using UnityEngine;

public class UIButton : MonoBehaviour
{

    [SerializeField]
    private GameObject targetObject;
    [SerializeField]
    private string targetMessage;

    public Color hightlightColor = Color.cyan;

    /// <summary>
    /// Called when the mouse enters the GUIElement or Collider.
    /// </summary>
    void OnMouseEnter()
    {
        SpriteRenderer render = this.GetComponent<SpriteRenderer>();
        if (null != render)
        {
            render.color = hightlightColor;
        }
    }

    /// <summary>
    /// Called when the mouse is not any longer over the GUIElement or Collider.
    /// </summary>
    void OnMouseExit()
    {
        SpriteRenderer render = this.GetComponent<SpriteRenderer>();
        if (null != render)
        {
            render.color = Color.white;
        }
    }

    /// <summary>
    /// OnMouseDown is called when the user has pressed the mouse button while
    /// over the GUIElement or Collider.
    /// </summary>
    void OnMouseDown()
    {
        this.transform.localScale = new Vector3(1.1f, 1.1f, 1.1f);
    }

    /// <summary>
    /// OnMouseUp is called when the user has released the mouse button.
    /// </summary>
    void OnMouseUp()
    {
        this.transform.localScale = Vector3.one;
        if (null != targetObject)
        {
            targetObject.SendMessage(targetMessage);
        }
    }
}
