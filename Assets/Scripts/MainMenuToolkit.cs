using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainMenuToolkit : MonoBehaviour
{
    private Button playButton;
    private Button quitButton;

    void OnEnable()
    {
        // UIDocument içindeki rootVisualElement'i al
        var root = GetComponent<UIDocument>().rootVisualElement;
        

        // UXML'deki butonu ismiyle bul
        playButton = root.Q<Button>("PlayButton");
        quitButton = root.Q<Button>("QuitButton");

        // Butona tıklama olayını bağla
        if (playButton != null)
        {
            playButton.clicked += OnPlayButtonClicked;
        }
            
        else
        {
            Debug.LogWarning("PlayButton bulunamadı! UXML dosyandaki isim doğru mu?");
        }

        if (quitButton != null)
        {
            quitButton.clicked += OnQuitButtonClicked;
        }

        else
        {
            Debug.LogWarning("PlayButton bulunamadı! UXML dosyandaki isim doğru mu?");
        }
    }

  

    private void OnPlayButtonClicked()
    {
       
        SceneManager.LoadScene(1);
    }

    public void OnQuitButtonClicked()
    {
        Application.Quit();
    }

    void OnDisable()
    {
        // Olay bağlantısını kaldırmak iyi bir pratiktir
        if (playButton != null)
        {
            playButton.clicked -= OnPlayButtonClicked;
        }

        if (quitButton != null)
        {
            quitButton.clicked -= OnQuitButtonClicked;
        }
            
    }
}
