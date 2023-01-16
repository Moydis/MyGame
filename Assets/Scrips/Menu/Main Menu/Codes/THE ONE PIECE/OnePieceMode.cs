using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(OnePieceCode))]
public class OnePieceMode : MonoBehaviour
{
    private OnePieceCode code;

    public Button OnePiece;

    void Awake()
    {
        code = GetComponent<OnePieceCode>();
    }

    void Update()
    {
        if (code.success)
        {
            OnePiece.gameObject.SetActive(true);
        }
    }
}
