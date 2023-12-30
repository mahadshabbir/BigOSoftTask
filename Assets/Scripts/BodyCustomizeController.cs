using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UMA;
using UMA.CharacterSystem;
using UnityEngine.UI;

public class BodyCustomizeController : MonoBehaviour
{

    public DynamicCharacterAvatar umaAvatar;
    private Dictionary<string, DnaSetter> dna;

    public Slider faceSlider, JawPositionSlider;

    private void Start()
    {
        dna=umaAvatar.GetDNA();
    }


    public void OnChangeFaceSize()
    {
        getDNA();
        if(dna!=null)
        {
            dna["headSize"].Set(faceSlider.value);
            umaAvatar.BuildCharacter();
        }
    }

    public void OnChangeJawPosition()
    {
        getDNA();
        if (dna != null)
        {
            dna["jawPosition"].Set(faceSlider.value);
            umaAvatar.BuildCharacter();
        }
    }



    void getDNA()
    {
        if(dna==null)
        {
            dna = umaAvatar.GetDNA();
        }
    }


}
