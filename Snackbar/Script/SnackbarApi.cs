using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SnackbarApi : MonoBehaviour
{
    [SerializeField] private SnackbarTheme snackbarTheme;

    [SerializeField] private RawImage Background;
    [SerializeField] private RawImage Icon;
    [SerializeField] private Button ActionButton;
    [SerializeField] private TMP_Text Message;

    [SerializeField] private GameObject SnackbarHolder;

    //singleton pattern
    public static SnackbarApi Instance;
    private void Awake()
    {
        if(Instance is null)
        {
            Instance = this;
        }
        else
        {
            Destroy(Instance);
        }
    }
    private void Start()
    {
        ChangeTheme();
    }
    public void ShowSnackbar(string message, string Buttontext, UnityAction action)
    {
        SnackbarHolder.SetActive(true);
        Message.text = message;
        ActionButton.GetComponentInChildren<TMP_Text>().text=Buttontext;
        SnackbarHolder.transform.localPosition = new Vector2(0, -Screen.height);
        SnackbarHolder.LeanMoveLocalY(0, 0.5f).setEaseOutExpo();
        ActionButton.onClick.AddListener(() =>
        {
            action();
            StartCoroutine(CloseSnackbar());
        });
    }
    private void ChangeTheme()
    {
        Background.color = snackbarTheme.BackgroundColor;
        Message.color = snackbarTheme.MessageColor;
        ActionButton.image.color = snackbarTheme.ButtonColor;
        Icon.color = snackbarTheme.IconColor;
    }

    IEnumerator CloseSnackbar()
    {
        SnackbarHolder.LeanMoveLocalY(-Screen.height, 0.5f).setEaseInOutCubic().delay = 0.6f;
        yield return null;
    }
}
