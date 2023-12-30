using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{


    /// <summary>
    /// Character Appearance Sliders
    /// </summary>
    public Slider faceSize, jawPosition, chinPosition,
                  cheekSize, jawsize, noseSize, lipSize,
                  bodyWeight, hipSize, breastSize,
                  height, skinTone;

    public Button MaleButton, FemaleButton;

    // Start is called before the first frame update
    void Start()
    {
        faceSize.onValueChanged.AddListener(Changefacesize);
        jawPosition.onValueChanged.AddListener(ChangeJawPosition);
        chinPosition.onValueChanged.AddListener(ChangeChinPisition);
        cheekSize.onValueChanged.AddListener(ChangeCheekSize);
        jawsize.onValueChanged.AddListener(ChangeJawSize);
        noseSize.onValueChanged.AddListener(ChangeNoseSize);
        lipSize.onValueChanged.AddListener (ChangeLipSize);
        bodyWeight.onValueChanged.AddListener(ChangeBodyWeight);   
        hipSize.onValueChanged .AddListener(ChangeHipSize);
        breastSize.onValueChanged.AddListener(ChangeBreastSize);
        height.onValueChanged .AddListener(ChangeHeight);   
        skinTone.onValueChanged .AddListener(ChangeSkinTone);

        //////////////
        /// GenderButton Listners
        MaleButton.onClick.AddListener(SelectMale);
        FemaleButton.onClick.AddListener(SelectFemale);
        //////////////
        ///

    }

    #region CharacterCustomization UI

    void Changefacesize(float value)
    {
        GameManager.Instance.CharacterController.OnChangeFaceSize(value); 
    }

    void ChangeJawPosition(float value)
    {
        GameManager.Instance.CharacterController.OnChangeJawPosition(value);

    }

    void ChangeChinPisition(float value)
    {
        GameManager.Instance.CharacterController.OnChangeChinPosition(value);
    }

    void ChangeCheekSize(float value)
    {
        GameManager.Instance.CharacterController.OnChangeCheekSize(value);
    }

    void ChangeJawSize(float value)
    {
        GameManager.Instance.CharacterController.OnChangeJawSize(value);    
    }

    void ChangeNoseSize(float value)
    {
        GameManager.Instance.CharacterController.OnChangeNoseSize(value);
    }

    void ChangeLipSize(float value)
    {
        GameManager.Instance.CharacterController.OnChangeLipSize(value);
    }

    void ChangeLipPosition(float value)
    {
        GameManager.Instance.CharacterController.OnChangeLipPosition(value);
    }

    void ChangeBodyWeight(float value)
    {
        GameManager.Instance.CharacterController.OnChangeWeight(value);
    }

    void ChangeHipSize(float value)
    {
        GameManager.Instance.CharacterController.OnHipSize(value);
    }
    void ChangeBreastSize(float value)
    {
        GameManager.Instance.CharacterController.OnBreastSize(value);    
    }

    void ChangeHeight(float value)
    {
        GameManager.Instance.CharacterController.OnHeight(value);
    }

    void ChangeSkinTone(float value)
    {

    }

    #endregion

    #region GenderSelectionUI

    void SelectMale()
    {
        GameManager.Instance.CharacterController.SelectMale();
    }

    void SelectFemale()
    {
        GameManager.Instance.CharacterController.SelectFeMale();
    }

    #endregion

}
