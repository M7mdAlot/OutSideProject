using UnityEngine;
using TMPro;

public class Book : MonoBehaviour
{
    public GameObject BookCanvas;
    public TMP_Text BookText;

    void Start()
    {
        BookCanvas.SetActive(false);
    }

    void Update()
    {
        if (BookCanvas.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.D))
                NextPage();

            if (Input.GetKeyDown(KeyCode.A))
                PrevPage();
        }
    }

    public void OpenBook()
    {
        Time.timeScale = 0f;
        BookCanvas.SetActive(true);
        BookText.pageToDisplay = 1;
    }

    public void CloseBook()
    {
        BookCanvas.SetActive(false);
        Time.timeScale = 1f;

    }

    public void NextPage()
    {
        if (BookText.pageToDisplay < BookText.textInfo.pageCount)
            BookText.pageToDisplay++;
    }

    public void PrevPage()
    {
        if (BookText.pageToDisplay > 1)
            BookText.pageToDisplay--;
    }
}