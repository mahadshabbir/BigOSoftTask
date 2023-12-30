using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UMA;
using UMA.CharacterSystem;
using UnityEngine.UI;
using static UMA.CharacterSystem.DynamicCharacterAvatar;

public class BodyCustomizeController : MonoBehaviour
{

    public DynamicCharacterAvatar umaAvatar;
    private Dictionary<string, DnaSetter> dna;


    private void Start()
    {
       //. dna=umaAvatar.GetDNA();
    }

    #region Charater Custimization
    public void OnChangeFaceSize(float value)
    {
        getDNA();
        if(dna!=null)
        {
            dna["headSize"].Set(value);
            umaAvatar.BuildCharacter();
        }
    }

    public void OnChangeJawPosition(float value)
    {
        getDNA();
        if (dna != null)
        {
            dna["jawsPosition"].Set(value);
            umaAvatar.BuildCharacter();
        }
    }

    public void OnChangeChinPosition(float value)
    {
        getDNA();
        if (dna != null)
        {
            dna["chinPosition"].Set(value);
            umaAvatar.BuildCharacter();
        }
    }


    public void OnChangeCheekSize(float value)
    {
        getDNA();
        if (dna != null)
        {
            dna["cheekSize"].Set(value);
            umaAvatar.BuildCharacter();
        }
    }

    public void OnChangeJawSize(float value)
    {
        getDNA();
        if (dna != null)
        {
            dna["jawsSize"].Set(value);
            umaAvatar.BuildCharacter();
        }
    }

    public void OnChangeNoseSize(float value)
    {
        getDNA();
        if (dna != null)
        {
            dna["noseSize"].Set(value);
            umaAvatar.BuildCharacter();
        }
    }

    public void OnChangeLipSize(float value)
    {
        getDNA();
        if (dna != null)
        {
            dna["lipsSize"].Set(value);
            umaAvatar.BuildCharacter();
        }
    }

    public void OnChangeLipPosition(float value)
    {
        getDNA();
        if (dna != null)
        {
            dna["lipsPosition"].Set(value);
            umaAvatar.BuildCharacter();
        }
    }

    public void OnChangeWeight(float value)
    {
        getDNA();
        if (dna != null)
        {
            dna["upperWeight"].Set(value);
            umaAvatar.BuildCharacter();
        }
    }

    public void OnHipSize(float value)
    {
        getDNA();
        if (dna != null)
        {
            dna["gluteusSize"].Set(value);
            umaAvatar.BuildCharacter();
        }
    }

    public void OnBreastSize(float value)
    {
        getDNA();
        if (dna != null)
        {
            dna["breastSize"].Set(value);
            umaAvatar.BuildCharacter();
        }
    }

    public void OnHeight(float value)
    {
        getDNA();
        if (dna != null)
        {
            dna["height"].Set(value);
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
    #endregion

    #region GenderSelection

    public void SelectMale()
    {
        umaAvatar.ChangeRace("HumanMale");
        dna = umaAvatar.GetDNA();
        umaAvatar.BuildCharacter();
    }

    public void SelectFeMale()
    {
        umaAvatar.ChangeRace("HumanFemale");
        dna = umaAvatar.GetDNA();
        umaAvatar.BuildCharacter();
    }

    #endregion

}
