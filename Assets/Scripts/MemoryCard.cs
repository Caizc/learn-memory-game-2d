using UnityEngine;

public class MemoryCard : MonoBehaviour
{
    [SerializeField]
    private GameObject cardBack;

    [SerializeField]
    private SceneController controller;

    private int _id;

    public int id
    {
        get { return _id; }
    }

    public void SetCard(int id, Sprite image)
    {
        _id = id;
        this.GetComponent<SpriteRenderer>().sprite = image;
    }

    public void Unreveal()
    {
        cardBack.SetActive(true);
    }

    /// <summary>
    /// OnMouseDown is called when the user has pressed the mouse button while
    /// over the GUIElement or Collider.
    /// </summary>
    void OnMouseDown()
    {
        if (cardBack.activeSelf && controller.canReveal)
        {
            // Debug.Log("Mouse click!");
            cardBack.SetActive(false);
            controller.CardRevealed(this);
        }
    }
}
