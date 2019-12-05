using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguegeHandler : MonoBehaviour
{

    public string selected_language;
    public Text title;
    public Text start_btn_text;
    public Text about_btn_text;
    public Text about_title;
    public Text about_subtitle;
    public Text about_footer;

    void Awake()
    {
        selected_language = "en";
    }

    private void Update()
    {
        translateHome();
    }

    public void setSelectedLanguage(string language)
    {
        selected_language = language;
        translateHome();
    }

    void translateHome()
    {
        switch (selected_language)
        {
            case "en":
                title.text = "Virtual Catalogue";
                start_btn_text.text = "Start";
                about_btn_text.text = "About";
                about_title.text = "About";
                about_subtitle.text = "Designed and Created by";
                about_footer.text = "Copyright © 2019";
                break;
            case "pt":
                title.text = "Catálogo Virtual";
                start_btn_text.text = "Iniciar";
                about_btn_text.text = "Sobre";
                about_title.text = "Sobre";
                about_subtitle.text = "Idealizado e Desenvolvido por";
                about_footer.text = "Todos os direitos reservados © 2019";
                break;
            case "pl":
                title.text = "Katalog Wirtualny";
                start_btn_text.text = "Początek";
                about_btn_text.text = "Dookoła";
                about_title.text = "Dookoła";
                about_subtitle.text = "Zaprojektowany i Stworzony przez";
                about_footer.text = "Prawa Autorskie © 2019";
                break;
        }
    }
}
